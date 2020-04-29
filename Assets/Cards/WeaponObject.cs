﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponObject : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public int maxDurability = 5;
    public int currDurrability = 5;
    public int damage = 5;
    public int cost = 1;
    public void ExecuteEffect()
    {

        if (battlegenerator_CS.hero_CS.energy >= 1 && this.currDurrability >= 1)
        {
            battlegenerator_CS.enemy_CS.SubstractHP(this.damage);
            this.currDurrability--;
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


