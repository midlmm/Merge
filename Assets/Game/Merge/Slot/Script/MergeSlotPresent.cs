using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MergeSlotPresent : BaseSlotPresent
{
    private protected override bool CheckingDrop(PlantItem mergeItem)
    {
        if (_baseSlot.PlantItem == null)
        {
            return true;
        }
        else if (_baseSlot.PlantItem.Stage == mergeItem.Stage)
        {
            _baseSlot.Accent(mergeItem);
            return true;
        }
        else
        {
            return false;
        }
    }

}
