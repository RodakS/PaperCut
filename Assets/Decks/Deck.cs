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
        battlegenerator_CS.hud_CS.DeckUpdate(deckList.Count);
    }

    public void CardPlay(BattleGenerator battlegenerator_CS,int cardNumer)
    {
        if (cardOnSlot[cardNumer - 1].cardCost <= battlegenerator_CS.hero_CS.energy)
        {
            cardOnSlot[cardNumer - 1].Effect(battlegenerator_CS);           
            CardDraw(cardNumer);
        }
    }

    public void CardDraw(int cardNumer)
    {
        int i= Random.Range(0, deckList.Count);
        cardFromDeck = deckList[i];
        cardFromDeck.Replace();                                            
        cardOnSlot[cardNumer - 1] = cardFromDeck;
        battlegenerator_CS.hud_CS.CardUpdate(cardFromDeck, cardNumer);
        deckList.RemoveAt(i);   //usuwam zagrana karte
        battlegenerator_CS.hud_CS.DeckUpdate(deckList.Count);
    }
}