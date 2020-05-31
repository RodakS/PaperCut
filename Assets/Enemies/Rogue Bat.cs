using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RogueBat : Enemy
{

    public RogueBat()
    {
        this.maxhp = 10;
        this.hp = 10;
        this.shield = 0;
    }


    public override void ExecuteTurn()
    {
        if (!(this.IsDead()))
        {
            if (this.setOnFire > 0)
            {
                this.SubstractHP(3);
                this.setOnFire--;
            }
            if (this.sleep > 0)
            {
                this.intent = -2;
                this.sleep--;
            }

            switch (intent)
            {
                case 1:
                    battlegenerator_CS.hero_CS.SubstractHP(6 + strength - weak);
                    break;
                case 2:
                    this.shield += (10 + dexterous - frail);
                    break;
                case 3:
                    this.shield += (6 + dexterous - frail);
                    this.strength += 2;
                    break;


            }
            this.CalculateMove();
        }
    }


    public override void CalculateMove()
    {
        stun = 0;
        int attackMove = 5;
        int defenseMove = 8;
        if (battlegenerator_CS.hero_CS.hp < battlegenerator_CS.hero_CS.hp / 2) attackMove++;
        if (this.hp < this.hp / 2) defenseMove--;
        int decision = Random.Range(0, 11);
        if (decision < attackMove)
            intent = 1;
        else if (decision > defenseMove)
            intent = 2;
        else intent = 3;
    }


    public override string IntentText()
    {
        string text = "";
        switch (this.intent)
        {

            case 1:
                text = "Attack for " + (int)(this.strength + 5);
                break;
            case 2:
                text = "Defend for 10";
                break;
            case 3:
                text = "Defend for 6, 2 strength up";
                break;
            case -1:
                text = "Fuck I'm stunned";
                break;
            case -2:
                text = "zZzZzZz";
                break;
        }
        return text;

    }




}



