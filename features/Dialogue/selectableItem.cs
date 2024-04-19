using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectableItem : MonoBehaviour
{
    public Sprite hovered;
    public Sprite notHovered;
//    public Script moveScript;
    public SpriteRenderer selectableObj;
    public Canvas dialougueCavas;

    void OnMouseOver()
    {
        selectableObj.sprite = hovered;
        GameObject.Find("Player").GetComponent<moveScript>().canWalk = false;
    }

    void OnMouseExit()
    {
        selectableObj.sprite = notHovered;
        GameObject.Find("Player").GetComponent<moveScript>().canWalk = true;
    }

    void OnMouseDown()
    {
        dialougueCavas.gameObject.SetActive(true);
    }

}