using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenSlot : BaseSlot
{
    public override void Accent(PlantItem mergeItem)
    {
        SetMergeItem(mergeItem);
    }
}
