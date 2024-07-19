using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseSlotPresent : MonoBehaviour
{
    [SerializeField] private protected BaseSlot _baseSlot;

    public void OnDropped(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        PlantItemView mergeItemView = dropped.GetComponent<PlantItemView>();
        PlantItem mergeItem = dropped.GetComponent<PlantItem>();
        if (CheckingDrop(mergeItem))
        {
            mergeItemView.SetDragParent(transform);
        }
    }

    private protected abstract bool CheckingDrop(PlantItem mergeItem);
}
