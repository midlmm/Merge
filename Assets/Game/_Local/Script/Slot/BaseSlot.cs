using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSlot : MonoBehaviour
{
    public PlantItem PlantItem { get; private set; }

    public void SetMergeItem(PlantItem mergeItem)
    {
        PlantItem = mergeItem;
    }

    public abstract void Accent(PlantItem mergeItem);
}
