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
    public int isUpgraded = 0;
    public bool isExhaust = false;
    public bool isFragile = false;
    public void CardUpgrade()
    {
        isUpgraded = 1;
    }
    public abstract void Replace();
    public abstract void Effect(BattleGenerator tmp);
}

public class BlankCard : CardTemplate
{
    public override void Replace()
    {
        cardName = " ";
        cardDescription = " ";
        cardCost = 99;
        cardSprite = null;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {

    }
}