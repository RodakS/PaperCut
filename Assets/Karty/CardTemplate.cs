using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardTemplate : MonoBehaviour
{
    public string cardName = "PAtak";
    public string cardDescription = "Łubudubu";
    public int cardCost = 12;
    public abstract void Replace();
    public abstract void Effect(BattleGenerator tmp);
}
