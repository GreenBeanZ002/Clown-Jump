using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryMove : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0) // will only run this code when there is no other objects as a child in one of the inventory slots
        {
            GameObject dropped = eventData.pointerDrag; //returns the gameobject this script is attached to
            DraggableObj draggableObj = dropped.GetComponent<DraggableObj>(); // accessing draggable obj script
            draggableObj.parentAfterDragging = transform;
        }
    }
}

