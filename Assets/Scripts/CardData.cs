using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class CardData : ScriptableObject {
    [Header("#CardInfo")]
    private string name;
    public string Name {
        get { return name; }
    }
    private Image icon;
    public Image Icon {
        get { return icon; }
    }
    private string desc;
    public string Desc {
        get { return desc; }
    }

    [Header("#Stat")]
    private int damage;
}
