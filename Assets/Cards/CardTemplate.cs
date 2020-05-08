using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardTemplate : MonoBehaviour
{
    public string cardName = "PAtak";
    public string cardDescription = "Łubudubu";
    public int cardCost = 12;
    public Sprite cardSprite;

    public abstract void Replace();
    public abstract void Effect(BattleGenerator tmp);
}
