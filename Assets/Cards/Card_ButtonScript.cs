using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_ButtonScript : MonoBehaviour
{
    private Button button;
    private CardTemplate cardTemplate_CS;
    private int cardNumberFromDeck;
    private MainDeck mainDeck_CS;
    public CampFireScript campFire_CS;
    private void Start()
    {
        button = GetComponent<Button>();
        mainDeck_CS = GameObject.FindWithTag("DeckTag").GetComponent<MainDeck>();
        campFire_CS = GameObject.FindWithTag("CampFireTag").GetComponent<CampFireScript>();
    }
    public void inCampfire(bool b)
    {
        campFire_CS.isInCampfire = b;

    }
    public void onClickCardUpgrade()
    { 
        if (mainDeck_CS.mainDeckList[cardNumberFromDeck].isUpgraded == 0 && campFire_CS.isInCampfire == true)
        { 
            mainDeck_CS.mainDeckList[cardNumberFromDeck].isUpgraded = 1;
            button.interactable = false;
        }
    }
    public void setCardTemplate(CardTemplate tmp, int i)
    {
        cardNumberFromDeck = i;
        cardTemplate_CS = tmp;
    }
}
