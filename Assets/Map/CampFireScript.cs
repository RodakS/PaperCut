using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFireScript : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;

    public bool isInCampfire = false;
    public void onHealButtonClick()
    {
        battlegenerator_CS.hero_CS.hp += (battlegenerator_CS.hero_CS.maxhp/4);
        if (battlegenerator_CS.hero_CS.hp > battlegenerator_CS.hero_CS.maxhp)
        {
            battlegenerator_CS.hero_CS.hp = battlegenerator_CS.hero_CS.maxhp;
        }
    }

    public void inCampfire(bool b)
    {
        isInCampfire = b;
    }
}
