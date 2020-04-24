using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartaPierwsza : KartaOrginalna
{
   // public BattleGenerator battlegenerator_CS;
    void Start()
    {
        //battlegenerator_CS = GameObject.FindGameObjectWithTag("GameController").GetComponent<BattleGenerator>();
        Name = " Pierwsza";
        Description = " costam";
        Cost = 2;
    }

    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.energy >= 1)
        {
            battlegenerator_CS.enemy_CS.substractHP(10);
            battlegenerator_CS.hero_CS.energy -= 1;
        }
    }

}

