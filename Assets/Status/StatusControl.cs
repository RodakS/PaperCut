using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusControl : MonoBehaviour
{
    public BattleGenerator battleGenerator_CS;
    public Text strength;
    public Text weak;
    public Text frail;
    public Text dexterous;
    public Text regenerate;
    public Text setonfire;
    public Text vulnerable;
    public Text bounty;
    public Text stun;
    public Text sleep;

    public void UpdateWithHero()
    {
        this.strength.text = battleGenerator_CS.hero_CS.strength.ToString();
        this.weak.text = battleGenerator_CS.hero_CS.weak.ToString();
        this.frail.text = battleGenerator_CS.hero_CS.frail.ToString();
        this.dexterous.text = battleGenerator_CS.hero_CS.dexterous.ToString();
        this.regenerate.text = battleGenerator_CS.hero_CS.regeneration.ToString();
        this.setonfire.text = battleGenerator_CS.hero_CS.setOnFire.ToString();
        this.vulnerable.text = battleGenerator_CS.hero_CS.vulnerable.ToString();
        this.bounty.text = battleGenerator_CS.hero_CS.bounty.ToString();
        this.stun.text = battleGenerator_CS.hero_CS.stun.ToString();
        this.sleep.text = battleGenerator_CS.hero_CS.sleep.ToString();

    }

    public void UpdateWithEnemy1()
    {
        this.strength.text = battleGenerator_CS.enemy_CS.strength.ToString();
        this.weak.text = battleGenerator_CS.enemy_CS.weak.ToString();
        this.frail.text = battleGenerator_CS.enemy_CS.frail.ToString();
        this.dexterous.text = battleGenerator_CS.enemy_CS.dexterous.ToString();
        this.regenerate.text = 0.ToString();
        this.setonfire.text = battleGenerator_CS.enemy_CS.setOnFire.ToString();
        this.vulnerable.text = battleGenerator_CS.enemy_CS.vulnerable.ToString();
        this.bounty.text = battleGenerator_CS.enemy_CS.bounty.ToString();
        this.stun.text = battleGenerator_CS.enemy_CS.stun.ToString();
        this.sleep.text = battleGenerator_CS.enemy_CS.sleep.ToString();

    }
    public void UpdateWithEnemy2()
    {
        this.strength.text = battleGenerator_CS.enemy_CS2.strength.ToString();
        this.weak.text = battleGenerator_CS.enemy_CS2.weak.ToString();
        this.frail.text = battleGenerator_CS.enemy_CS2.frail.ToString();
        this.dexterous.text = battleGenerator_CS.enemy_CS2.strength.ToString();
        this.regenerate.text = 0.ToString();
        this.setonfire.text = battleGenerator_CS.enemy_CS2.setOnFire.ToString();
        this.vulnerable.text = battleGenerator_CS.enemy_CS2.vulnerable.ToString();
        this.bounty.text = battleGenerator_CS.enemy_CS2.bounty.ToString();
        this.stun.text = battleGenerator_CS.enemy_CS2.stun.ToString();
        this.sleep.text = battleGenerator_CS.enemy_CS2.sleep.ToString();

    }
    public void UpdateWithEnemy3()
    {
        this.strength.text = battleGenerator_CS.enemy_CS3.strength.ToString();
        this.weak.text = battleGenerator_CS.enemy_CS3.weak.ToString();
        this.frail.text = battleGenerator_CS.enemy_CS3.frail.ToString();
        this.dexterous.text = battleGenerator_CS.enemy_CS3.strength.ToString();
        this.regenerate.text = 0.ToString();
        this.setonfire.text = battleGenerator_CS.enemy_CS3.setOnFire.ToString();
        this.vulnerable.text = battleGenerator_CS.enemy_CS3.vulnerable.ToString();
        this.bounty.text = battleGenerator_CS.enemy_CS3.bounty.ToString();
        this.stun.text = battleGenerator_CS.enemy_CS3.stun.ToString();
        this.sleep.text = battleGenerator_CS.enemy_CS3.sleep.ToString();

    }
}
