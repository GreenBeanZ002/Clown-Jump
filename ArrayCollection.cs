using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCollection : MonoBehaviour
{

    public DraggableItem[] objectsWithScript;
    public DraggableItem draggableItemScript; 
    public GameObject InputA;
    public GameObject InputB;
    public GameObject InputC;
    public GameObject InputD;


    void Start()
    {
        FindObjectsWithSpecificScript(); 
    }

    void FindObjectsWithSpecificScript()
    {
        objectsWithScript = GameObject.FindObjectsOfType<DraggableItem>();
        // Put the ingredient names in the <> section 
    }

    public void Execute()
    {
       foreach (DraggableItem obj in objectsWithScript)
       {
           
           if (obj.transform.position == InputA.transform.position ||
            obj.transform.position == InputB.transform.position ||
            obj.transform.position == InputC.transform.position ||
            obj.transform.position == InputD.transform.position)
           {
             Destroy(obj.gameObject);

           }
       }
    }
}