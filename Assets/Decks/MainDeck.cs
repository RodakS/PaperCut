using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDeck : MonoBehaviour
{
    public List<CardTemplate> mainDeckList = new List<CardTemplate>();
    public GameObject[] cardToChooseButtons;
    List<CardTemplate> cardsToChooseList = new List<CardTemplate>();

    List<CardTemplate> cardsCommonList = new List<CardTemplate>();
    List<CardTemplate> cardsRareList = new List<CardTemplate>();
    List<CardTemplate> cardsLegendaryList = new List<CardTemplate>();
    private void Start()
    {
        GenerateStartingDeck();
        GenerateAllCards();
        GenerateRandomCard();
    }
    public void GenerateAllCards() // tu pododawać wszystkie karty po 1sztuce do odpowiedniej rzadkosci
    {
        //COMMONY
        cardsCommonList.Add(new CardDamage2());
        cardsCommonList.Add(new CardDamage1());
        cardsCommonList.Add(new CardDamage3());
        cardsCommonList.Add(new CardBlock1());
        cardsCommonList.Add(new CardRegeneration());
        cardsCommonList.Add(new CardPanic());
        cardsCommonList.Add(new CardShareTheWeakness());
        cardsCommonList.Add(new CardQuestionableStab());
        cardsCommonList.Add(new CardGainTheUpperHand());
        cardsCommonList.Add(new CardPickpocket());
        cardsCommonList.Add(new CardDaylightRobbery());
        cardsCommonList.Add(new CardMoneyPunch());
        cardsCommonList.Add(new CardFairTrade());
        cardsCommonList.Add(new CardBastion());
        cardsCommonList.Add(new CardGamblingHeart());
        cardsCommonList.Add(new CardAceInTheHole());
        //cardsCommonList.Add(new Card());
        //RARY
        cardsRareList.Add(new CardPenetratingHit());
        cardsRareList.Add(new CardStun());
        cardsRareList.Add(new CardHealth());
        cardsRareList.Add(new CardHeal());
        cardsRareList.Add(new CardSweepingEdge());
        cardsRareList.Add(new CardFire());
        cardsRareList.Add(new CardChloroform());
        cardsRareList.Add(new CardFinishingBlow());
        cardsRareList.Add(new CardShoplift());
        cardsRareList.Add(new CardQuickMoney());
        cardsRareList.Add(new CardSilverSword());
        cardsRareList.Add(new CardBasicEconomy());
        cardsRareList.Add(new CardTargetPractice());
        //cardsRareList.Add(new Card());
        // LEGENDY
        cardsLegendaryList.Add(new CardFiraga());
        cardsLegendaryList.Add(new CardTheGrandHeist());
        cardsLegendaryList.Add(new CardOneTimeChance());
        cardsLegendaryList.Add(new CardSuddenBossfight());
        cardsLegendaryList.Add(new CardGoldenSlash());
        cardsLegendaryList.Add(new CardAegisOfGold());
        cardsLegendaryList.Add(new CardMoneyIsPower());
        cardsLegendaryList.Add(new CardFluidExchange());
        cardsLegendaryList.Add(new CardOneForAll());
        cardsLegendaryList.Add(new CardAllForOne());
        cardsLegendaryList.Add(new CardBasicMovements());
        cardsLegendaryList.Add(new CardFinishingThrust());
        cardsLegendaryList.Add(new CardFinalDefence());
        //cardsLegendaryList.Add(new Card());
    }
    public void GenerateStartingDeck()  // tu sa startowe karty
    {
        mainDeckList.Add(new CardHeal());     
        mainDeckList.Add(new CardBlock1());
        mainDeckList.Add(new CardPanic());
        mainDeckList.Add(new CardShareTheWeakness());

        mainDeckList.Add(new CardDamage1());
        mainDeckList.Add(new CardDamage3());
        mainDeckList.Add(new CardPickpocket());
        mainDeckList.Add(new CardPenetratingHit());

    }

    public void GenerateRandomCard()
    {
        cardsToChooseList.Clear();
        for (int i = 0; i < 4; i++)
        {
            int rarityRandomNumber = Random.Range(1, 100);
       
            if (rarityRandomNumber < 60)  // 60% na wyciągnięcie commona
            {
                int j = Random.Range(0, cardsCommonList.Count);
                cardsToChooseList.Add(cardsCommonList[j]);
            }
            else if (rarityRandomNumber < 90)  // 30% na wyciągnięcie rara
            {
                int j = Random.Range(0, cardsRareList.Count);
                cardsToChooseList.Add(cardsRareList[j]);
            }
            else                                     // 10% na wyciągnięcie lengendara
            {
                int j = Random.Range(0, cardsLegendaryList.Count);
                cardsToChooseList.Add(cardsLegendaryList[j]);
            }

            cardsToChooseList[i].Replace();
            cardToChooseButtons[i].transform.GetChild(0).GetComponent<Text>().text = cardsToChooseList[i].cardName;
            cardToChooseButtons[i].transform.GetChild(1).GetComponent<Text>().text = cardsToChooseList[i].cardDescription;
            cardToChooseButtons[i].transform.GetChild(2).GetComponent<Text>().text = cardsToChooseList[i].cardCost.ToString();
            cardToChooseButtons[i].GetComponent<Image>().sprite = cardsToChooseList[i].cardSprite;
        }
    }

        public void OnChooseButtonClick(int i)
        {
            mainDeckList.Add(cardsToChooseList[i]);
                GenerateRandomCard();
        }
    
}
