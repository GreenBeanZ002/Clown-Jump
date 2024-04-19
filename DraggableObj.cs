using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; //this is to allow me to use unity's pre made event system

public class DraggableObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Item item;

    public Image image;
    [HideInInspector] public Transform parentAfterDragging; // want this to be assigned to a new parent wherever dropped in inventory slots

    public void Start()
    {
        InitialiseItem(item);
    }

    public void InitialiseItem(Item newItem)
    {
        image.sprite = newItem.image;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("start dragging");
        parentAfterDragging = transform.parent; // this sets the objects current place in the heirarchy to be the parent
        transform.SetParent(transform.root); // returns topmost transform (we want the item to be over everything in heirarchy)
        transform.SetAsLastSibling(); // this way nothing should block view of the item as we drag
        image.raycastTarget = false; // when dropping the object, if this is on, unity will try to drop item onto itself, we do this so it
        // doesn't interact with item when dropping and will go into available slot
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end dragging");
        transform.SetParent(parentAfterDragging); // setting original heirarchy again once player finished dragging
        image.raycastTarget = true; // so we can interact with object after dropping somewhere

    }
}
