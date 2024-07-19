using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseSlotView : MonoBehaviour, IDropHandler
{
    [SerializeField] private BaseSlotPresent _baseSlotPresent;

    public void OnDrop(PointerEventData eventData)
    {
        _baseSlotPresent.OnDropped(eventData);
    }
}
