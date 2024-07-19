using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantItem : MonoBehaviour
{
    public int Stage { get; private set; }

    [SerializeField] private PlantItemView _plantItemView;
    [SerializeField] private PlantItemData _plantItemData;

    private void Start()
    {
        _plantItemView.DisplayStage(_plantItemData.PlantItemConfigs[Stage].Color);
    }

    public void SetStage(int stage)
    {
        Stage = stage;
        _plantItemView.DisplayStage(_plantItemData.PlantItemConfigs[Stage].Color);
    }
}
