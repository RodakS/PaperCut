using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;

    public int maxDurability = 5;
    public int currDurability = 5;
    public int armor = 5;
    public int cost = 1;
    public void ExecuteEffect()
    {

        if (battlegenerator_CS.hero_CS.energy >= 1 && this.currDurability >= 1)
        {
            battlegenerator_CS.hero_CS.shield += this.armor;
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
