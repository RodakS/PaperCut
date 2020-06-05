using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    private MainDeck maindeck_CS;
    CardTemplate cardFromDeck;
    CardTemplate[] cardOnSlot = new CardTemplate[3];
    public List<CardTemplate> deckList;
    public List<CardTemplate> graveyardList;
    public List<CardTemplate> exhaustList;
    public void Generate()
    {
        maindeck_CS = GetComponent<MainDeck>();
        deckList = new List<CardTemplate> (maindeck_CS.mainDeckList);

        DrawStartCards();
    }

    void DrawStartCards()
    {
        for (int cardNumer = 1; cardNumer < 4; cardNumer++)
        {
            int i=Random.Range(0, deckList.Count);
            cardFromDeck = deckList[i];
            cardFromDeck.Replace();
            battlegenerator_CS.hud_CS.CardUpdate(cardFromDeck, cardNumer);
            cardOnSlot[cardNumer - 1] = cardFromDeck;

            deckList.RemoveAt(i);
        }
        battlegenerator_CS.hud_CS.DeckUpdate(deckList.Count,graveyardList.Count, exhaustList.Count);
    }

    public void CardPlay(BattleGenerator battlegenerator_CS,int cardNumer)
    {
        if (!(cardOnSlot[cardNumer - 1].requiresTarget) || !(battlegenerator_CS.targetedEnemy is null))
        {
            if (cardOnSlot[cardNumer - 1].cardCost <= battlegenerator_CS.hero_CS.energy)
            {

                
                cardOnSlot[cardNumer - 1].Effect(battlegenerator_CS);
                if (cardOnSlot[cardNumer - 1].isExhaust == true)
                {
                    exhaustList.Add(cardOnSlot[cardNumer - 1]);
                }
                else { graveyardList.Add(cardOnSlot[cardNumer - 1]); }

                if (deckList.Count == 0)
                {
                    cardOnSlot[cardNumer - 1] = new BlankCard();
                    cardOnSlot[cardNumer - 1].Replace();
                    battlegenerator_CS.hud_CS.CardUpdate(cardOnSlot[cardNumer - 1], cardNumer);
                }
                else { CardDraw(cardNumer); }
                battlegenerator_CS.pointer_CS.HideThis();
            }
        }
    }

    public void CardDraw(int cardNumer)
    {
            int i = Random.Range(0, deckList.Count);
            cardFromDeck = deckList[i];
            cardFromDeck.Replace();
            cardOnSlot[cardNumer - 1] = cardFromDeck;
            battlegenerator_CS.hud_CS.CardUpdate(cardFromDeck, cardNumer);
            if (cardOnSlot[cardNumer - 1].isFragile == true)
            {
             maindeck_CS.mainDeckList.RemoveAt(i);
            }
            deckList.RemoveAt(i);   //usuwam zagrana karte
            battlegenerator_CS.hud_CS.DeckUpdate(deckList.Count, graveyardList.Count, exhaustList.Count);
    }
}