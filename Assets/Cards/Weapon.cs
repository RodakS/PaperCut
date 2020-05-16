using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public int maxDurability = 5;
    public int currDurability = 5;
    public int damage = 5;
    public int cost = 1;
    public void ExecuteEffect()
    {

        if (battlegenerator_CS.hero_CS.energy >= 1 && this.currDurability >= 1 && !(battlegenerator_CS.targetedEnemy is null))
        {
            battlegenerator_CS.targetedEnemy.SubstractHP(this.damage+battlegenerator_CS.hero_CS.strength-battlegenerator_CS.hero_CS.weak);
            this.currDurability--;
            battlegenerator_CS.hero_CS.energy--;
        }


    }
    void Start()
    {

    }

    void Update()
    {

    }

}


