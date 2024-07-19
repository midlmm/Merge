using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSlot : BaseSlot
{
    public override void Accent(PlantItem mergeItem)
    {
        Destroy(PlantItem.gameObject);
        SetMergeItem(mergeItem);
        PlantItem.SetStage(PlantItem.Stage + 1);
    }
}
