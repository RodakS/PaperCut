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

    public BattleGenerator battlegenerator_CS;
    public void UpdateHUD()
    {
         enemyHPText.text = battlegenerator_CS.enemy_CS.HP + "/" + battlegenerator_CS.enemy_CS.MaxHP;
        heroHPText.text = battlegenerator_CS.hero_CS.HP + "/" + battlegenerator_CS.hero_CS.MaxHP;
        enemyShieldText.text = "Shield: " + battlegenerator_CS.enemy_CS.Shield;
        heroShieldText.text = "Shield: " + battlegenerator_CS.hero_CS.Shield;
        heroEnergy.text = "Energy:" + battlegenerator_CS.hero_CS.energy + "/" + battlegenerator_CS.hero_CS.maxenergy;
        enemyStrength.text = "Strength : " + battlegenerator_CS.enemy_CS.AttackUp;
        heroStrength.text = "Strength : " + battlegenerator_CS.hero_CS.AttackUp;
       // Durability.text = "Durability : "+ battlegenerator_CS.weaponObject.CurrDurrability+ "/"+battlegenerator_CS.weaponObject.MaxDurability + " Durability : " + battlegenerator_CS.shieldObject.CurrDurrability + "/" + battlegenerator_CS.shieldObject.MaxDurability;
        switch (battlegenerator_CS.enemy_CS.intent) // cały ten switch ma być u przeciwnika a nie tutaj
        {
            case 1:
                enemyIntent.text = "Attack for " +(int) (battlegenerator_CS.enemy_CS.AttackUp + 5);
                break;
            case 2:
                enemyIntent.text = "Defend for 10";
                break;
            case 3:
                enemyIntent.text = "Defend for 6, 2 strength up";
                break;
            case -1:
                enemyIntent.text = "Fuck I'm stunned";
                break;
            case -2:
                enemyIntent.text = "zZzZzZz";
                break;
        }

       
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
    }
}
