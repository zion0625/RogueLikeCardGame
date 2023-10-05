using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropCheck : MonoBehaviour, IDropHandler {
    public static DropCheck instance;

    private GameObject dragSlot;

    private void Awake() {
        instance = this;
    }
    
    public void OnDrop(PointerEventData eventData) {
        if (dragSlot != null) {
            dragSlot.GetComponent<Card>().UseCard();
        }
    }

    public void UseSlot(GameObject card) {
        dragSlot = card;
    }
}
