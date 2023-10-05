using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CardData")]
public class CardData : ScriptableObject {
    public enum CardType { Attack, Defence, Support }
    public enum Buffs { None, Strength, Durability, Regen, Invincible }
    public enum DeBuffs { None, Burn, Poison, Stun, Weak, Blind}
    
    [Header("#CardInfo")]
    [SerializeField]
    private string name;
    public string Name {
        get { return name; }
    }
    
    [SerializeField]
    private Sprite icon;
    public Sprite Icon {
        get { return icon; }
    }
    
    [SerializeField]
    [TextArea]
    private string desc;
    public string Desc {
        get { return desc; }
    }

    [Header("#Stat")]
    [SerializeField]
    private int power;
    public int Power {
        get { return power; }
    }
    
    [SerializeField]
    private CardType type;
    public CardType Type {
        get { return type; }
    }
    
    [SerializeField]
    private Buffs buff;
    public Buffs Buff {
        get { return buff; }
    }
    
    [SerializeField]
    private DeBuffs deBuff;
    public DeBuffs DeBuff {
        get { return deBuff; }
    }
}
