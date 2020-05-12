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
    private void Start()
    {
        button = GetComponent<Button>();
        mainDeck_CS = GameObject.FindWithTag("DeckTag").GetComponent<MainDeck>();
    }

    public void onClickCardUpgrade()
    { 
        if (mainDeck_CS.mainDeckList[cardNumberFromDeck].isUpgraded == 0)
        { 
            mainDeck_CS.mainDeckList[cardNumberFromDeck].isUpgraded = 1;
            Debug.Log(mainDeck_CS.mainDeckList[cardNumberFromDeck].isUpgraded);
            // zamknij wybieranie karty do ulepszenia
        }
    }
    public void setCardTemplate(CardTemplate tmp, int i)
    {
        cardNumberFromDeck = i;
        cardTemplate_CS = tmp;
    }
}
