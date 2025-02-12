﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Text gold;
    // public Text enemyHPText; 
    public Text heroHPText;
  //  public Text enemyShieldText; 
    public Text heroShieldText;
    public Text statusText;
 //   public Text enemyStrength;
    public Text heroEnergy;
  //  public Text enemyIntent;
    public Text durability;
    public Text cards;
    public Text GraveyardCardsNumber;
    public Text ExhaustCardsNumber;
    public Text WeaponShieldDurability;
    public Text[] cardDescriptionTexts;
    public Image[] cardImageHUD;
    public BattleGenerator battlegenerator_CS;
    
    public void UpdateHUD()
    {
       
        heroHPText.text = battlegenerator_CS.hero_CS.hp + "/" + battlegenerator_CS.hero_CS.maxhp;
       
        heroShieldText.text = "Shield: " + battlegenerator_CS.hero_CS.shield;
        heroEnergy.text = "Energy:" + battlegenerator_CS.hero_CS.energy + "/" + battlegenerator_CS.hero_CS.maxenergy;
        gold.text = battlegenerator_CS.hero_CS.gold+" ";
        WeaponShieldDurability.text = "Durability " + battlegenerator_CS.weapon_CS.currDurability + "/" + battlegenerator_CS.weapon_CS.maxDurability + " Durability " + battlegenerator_CS.shield_CS.currDurability + "/" + battlegenerator_CS.shield_CS.maxDurability;
        battlegenerator_CS.enemy_CS.UpdateEnemyHUD();
        battlegenerator_CS.enemy_CS2.UpdateEnemyHUD();
        battlegenerator_CS.enemy_CS3.UpdateEnemyHUD();


        battlegenerator_CS.statuscontrol_CS.UpdateWithHero();

        battlegenerator_CS.deck_CS.UpdateCards();


    }
    public void StatusUpdate(BattleState STATE)
    {
            statusText.text = STATE + " ";
        battlegenerator_CS.statuscontrol_CS.ResetEnemyStatus();     // te 2 funkcje updatujo statusy na hudzie
        battlegenerator_CS.statuscontrol_CS.UpdateEnemiesStatus();
 
    }
    public void DeckUpdate(int s, int t, int p)
    {
        cards.text = s+ "";
        GraveyardCardsNumber.text = t + "";
        ExhaustCardsNumber.text = p + "";
    }
    public void CardUpdate(CardTemplate cardFromDeck, int cardNumer)
    {
        cardDescriptionTexts[3 * (cardNumer - 1) + 0].text = cardFromDeck.cardName;           //wyswietlam nowe wlasiwosci
        cardDescriptionTexts[3 * (cardNumer - 1) + 1].text = cardFromDeck.cardDescription;
        cardDescriptionTexts[3 * (cardNumer - 1) + 2].text = cardFromDeck.cardCost.ToString();
        cardImageHUD[cardNumer - 1].sprite = cardFromDeck.cardSprite;
    }
}
