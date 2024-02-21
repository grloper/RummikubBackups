using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileSlot : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount==Constants.EmptyTileSlot)
        {
            GameObject dropped = eventData.pointerDrag;
            Draggableitem draggableitem = dropped.GetComponent<Draggableitem>();
            draggableitem.parentAfterDrag = transform;
        }
    }
}
