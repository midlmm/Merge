using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenSlotPresent : BaseSlotPresent
{
    private protected override bool CheckingDrop(PlantItem mergeItem)
    {
        return true;
    }
}
