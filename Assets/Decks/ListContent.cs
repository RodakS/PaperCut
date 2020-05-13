using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ListContent : MonoBehaviour
{
    public GameObject cardFromListObject;
    private GameObject cardFromListObjectTMP;
    public GameObject viewPort;
    private Deck deck_CS;
    private MainDeck mainDeck_CS;
    public GameObject content;
    private List<CardTemplate> tmpList;
    void Start()
    {
        deck_CS = GetComponent<Deck>();
        mainDeck_CS = GetComponent<MainDeck>();
    }
    public void ShowCardsinList (string command) 
    {
        switch (command)
        {
            case "Show Deck":
                tmpList = deck_CS.deckList;
                break;

            case "Show General Deck":
                tmpList = mainDeck_CS.mainDeckList;
                break;

            case "Show Graveyard":
                tmpList = deck_CS.graveyardList;
                break;

            case "Show Exhaust Cards":
                tmpList = deck_CS.exhaustList;
                break;
        }

        for (int i = 0; i < tmpList.Count; i++)
        {

            tmpList[i].Replace();
            cardFromListObjectTMP = Instantiate(cardFromListObject,content.transform);
            cardFromListObjectTMP.transform.GetChild(0).GetComponent<Text>().text = tmpList[i].cardName;
            cardFromListObjectTMP.transform.GetChild(1).GetComponent<Text>().text = tmpList[i].cardDescription;
            cardFromListObjectTMP.transform.GetChild(2).GetComponent<Text>().text = tmpList[i].cardCost.ToString();
            cardFromListObjectTMP.GetComponent<Image>().sprite = tmpList[i].cardSprite;
            if ( command == "Show General Deck")
            {
                cardFromListObjectTMP.GetComponent<Card_ButtonScript>().setCardTemplate(tmpList[i],i);
            }
        }
    }
    public void ButtonShowListClick(string commandFromButton)
    {
        if (viewPort.active)
        {
            viewPort.active = false;
            DeleteCardInListContent();
        }
        else
        {
            ShowCardsinList(commandFromButton);
            viewPort.active = true;

        }
    }

    void DeleteCardInListContent()
    {
       foreach (Transform child in content.transform)
        {
           GameObject.Destroy(child.gameObject);
        }
    }

}
