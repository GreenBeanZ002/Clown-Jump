using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class interactObjDialogue : MonoBehaviour
{
    // I used the following guide to help me create the dialogue system: https://youtu.be/8oTYabhj248?si=LJ6QKyE6twm-sd6D
    //stuff to make box appear
    public Canvas dialougueCavas;
    private bool active;

    //stuff to write dialogue
    public TextMeshProUGUI dialogueComponent;
    public string[] dialogueLines;
    public float textSpeed;
    private int index;
 
    void Start()
    {
        dialogueComponent.text = string.Empty;
        
    }
    void OnMouseDown()
    {
        if (active == false)
        {
            dialougueCavas.enabled = true;
            active = true;
            StartDialogue();
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(dialogueComponent.text == dialogueLines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueComponent.text = dialogueLines[index];
            }
        }
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in dialogueLines[index].ToCharArray())
        {
            dialogueComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if(index < dialogueLines.Length - 1)
        {
            index++;
            dialogueComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialougueCavas.enabled = false;
        }
    }
}
