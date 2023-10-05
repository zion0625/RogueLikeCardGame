using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
    [SerializeField]
    private CardData data;

    private Image icon;
    private TextMeshProUGUI name;
    private TextMeshProUGUI desc;
    
    void Awake() {
        icon = GetComponentsInChildren<Image>()[1];
        TextMeshProUGUI[] tmp = GetComponentsInChildren<TextMeshProUGUI>();
        name = tmp[0];
        desc = tmp[1];
    }

    private void OnEnable() {
        icon.sprite = data.Icon;
        name.text = data.Name;
        desc.text = string.Format(data.Desc, data.Power);
    }

    public void UseCard() {
        gameObject.SetActive(false);
    }
}
