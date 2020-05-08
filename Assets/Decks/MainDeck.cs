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
        cardsCommonList.Add(new CardStun());
        cardsCommonList.Add(new CardHealth());
        cardsCommonList.Add(new CardHeal());
        cardsCommonList.Add(new CardDamage1());
        //RARY
        cardsRareList.Add(new CardPenetratingHit());
        cardsRareList.Add(new CardStun());
        cardsRareList.Add(new CardHealth());
        cardsRareList.Add(new CardHeal());
        cardsRareList.Add(new CardDamage1());
        // LEGENDY
        cardsLegendaryList.Add(new CardDamage1());
        cardsLegendaryList.Add(new CardDamage1());
        cardsLegendaryList.Add(new CardDamage1());
    }
    public void GenerateStartingDeck()  // tu sa startowe karty
    {
        mainDeckList.Add(new CardPenetratingHit());     
        mainDeckList.Add(new CardPenetratingHit());
        mainDeckList.Add(new CardPenetratingHit());
        mainDeckList.Add(new CardPenetratingHit());

        mainDeckList.Add(new CardSweepingEdge());
        mainDeckList.Add(new CardSweepingEdge());
        mainDeckList.Add(new CardSweepingEdge());
        mainDeckList.Add(new CardSweepingEdge());

    }

    public void GenerateRandomCard()
    {

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
                cardsToChooseList.Add(cardsCommonList[j]);
            }
            else                                     // 10% na wyciągnięcie lengendara
            {
                int j = Random.Range(0, cardsLegendaryList.Count);
                cardsToChooseList.Add(cardsCommonList[j]);
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
        }
    
}
