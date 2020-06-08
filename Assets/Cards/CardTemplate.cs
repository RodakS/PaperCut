using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardTemplate : MonoBehaviour
{
    public static int heroOffense = 0;
    public static int heroDefense = 0;
    public static int heroGold = 0;
    public string cardName = "PAtak";
    public string cardDescription = "Łubudubu";
    public int cardCost = 12;
    public Sprite cardSprite;
    public int isUpgraded = 0;
    public bool isExhaust = false;
    public bool isFragile = false;
    public bool requiresTarget = false;
    public void CardUpgrade()
    {
        isUpgraded = 1;
    }
    public abstract void Replace();
    public abstract void Effect(BattleGenerator tmp);
    public abstract void GetModifiers(BattleGenerator battlegenerator_CS);
   
}

public class BlankCard : CardTemplate
{
    public override void Replace()
    {
        cardName = "Void";
        cardDescription = "You have no more cards, receive 1 damage at the end of the turn.";
        cardCost = 99;
        cardSprite = Resources.Load<Sprite>("Tombstone");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {

    }
    public override void GetModifiers(BattleGenerator battlegenerator_CS)
    {
    }
}