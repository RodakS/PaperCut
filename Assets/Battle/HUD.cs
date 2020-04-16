using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text enemyHPText;    // do wyswietlania hp
    public Text heroHPText;
    public Text enemyShieldText;    // do wyswietlania tarczy
    public Text heroShieldText;
    public Text statusText;
    public Text enemyStrength;
    public Text heroEnergy;
    public Text enemyIntent;
    public Text heroStrength;
    public Text Durability;
    public Text cards;


    public void UpdateHUD(Enemy enemyUnit,Hero heroUnit,Weapon Weaponer,Shield Shielder)
    {
         enemyHPText.text = enemyUnit.HP + "/" + enemyUnit.MaxHP;
        heroHPText.text = heroUnit.HP + "/" + heroUnit.MaxHP;
        enemyShieldText.text = "Shield: " + enemyUnit.Shield;
        heroShieldText.text = "Shield: " + heroUnit.Shield;
        heroEnergy.text = "Energy:" + heroUnit.energy + "/" + heroUnit.maxenergy;
        enemyStrength.text = "Strength : " + enemyUnit.AttackUp;
        heroStrength.text = "Strength : " + heroUnit.AttackUp;
        Durability.text = "Durability : "+ Weaponer.CurrDurrability+ "/"+Weaponer.MaxDurability + " Durability : " + Shielder.CurrDurrability + "/" + Shielder.MaxDurability;
        switch (enemyUnit.intent)
        {
            case 1:
                enemyIntent.text = "Attack for " +(int) (enemyUnit.AttackUp + 5);
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
    public void DeckUpdate(string s)
    {
        cards.text = s;
    }
}
