using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text enemyHPText; 
    public Text heroHPText;
    public Text enemyShieldText; 
    public Text heroShieldText;
    public Text statusText;
    public Text enemyStrength;
    public Text heroEnergy;
    public Text enemyIntent;
    public Text heroStrength;
    public Text durability;
    public Text cards;
    public Text[] cardDescriptionTexts;
    public Image[] cardImageHUD;
    public BattleGenerator battlegenerator_CS;
    public void UpdateHUD()
    {
         enemyHPText.text = battlegenerator_CS.enemy_CS.hp + "/" + battlegenerator_CS.enemy_CS.maxhp;
        heroHPText.text = battlegenerator_CS.hero_CS.hp + "/" + battlegenerator_CS.hero_CS.maxhp;
        enemyShieldText.text = "Shield: " + battlegenerator_CS.enemy_CS.shield;
        heroShieldText.text = "Shield: " + battlegenerator_CS.hero_CS.shield;
        heroEnergy.text = "Energy:" + battlegenerator_CS.hero_CS.energy + "/" + battlegenerator_CS.hero_CS.maxenergy;
        enemyStrength.text = "Strength : " + battlegenerator_CS.enemy_CS.strength;
        heroStrength.text = "Strength : " + battlegenerator_CS.hero_CS.strength;
        enemyIntent.text = battlegenerator_CS.enemy_CS.IntentText();

       
    }
    public void StatusUpdate(BattleState STATE)
    {
            statusText.text = STATE + " ";
    }
    public void DeckUpdate(int s)
    {
        cards.text = "Cards left: " + s;
    }
    public void CardUpdate(CardTemplate cardFromDeck, int cardNumer)
    {
        cardDescriptionTexts[3 * (cardNumer - 1) + 0].text = cardFromDeck.cardName;           //wyswietlam nowe wlasiwosci
        cardDescriptionTexts[3 * (cardNumer - 1) + 1].text = cardFromDeck.cardDescription;
        cardDescriptionTexts[3 * (cardNumer - 1) + 2].text = cardFromDeck.cardCost.ToString();
        cardImageHUD[cardNumer - 1].sprite = cardFromDeck.cardSprite;
    }
}
