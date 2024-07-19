using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantItemPresent : MonoBehaviour
{
    [SerializeField] private PlantItem _plantItem;

    public void OnEnterDrag(BaseSlot baseSlot)
    {
        baseSlot.SetMergeItem(null);
    }

    public void OnEndDrag(BaseSlot baseSlot)
    {
        baseSlot.SetMergeItem(_plantItem);
    }
}
