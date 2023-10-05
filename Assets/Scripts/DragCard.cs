using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragCard : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private RectTransform rect;
    private Vector3 startPos;
    private Transform parent;
    private int index;

    private void Start() {
        rect = GetComponent<RectTransform>();
        parent = transform.parent;
        index = transform.GetSiblingIndex();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        DropCheck.instance.UseSlot(gameObject);
        startPos = transform.position;
        transform.SetParent(GameObject.FindGameObjectWithTag("UI Canvas").transform);
        transform.SetSiblingIndex(2);
        GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) {
        rect.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {
        DropCheck.instance.UseSlot(null);
        rect.position = startPos;
        transform.SetParent(parent);
        transform.SetSiblingIndex(index);
        GetComponent<Image>().raycastTarget = true;
    }
}
