using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rzdzor : Enemy
{
    public Rzdzor()
    {
        this.maxhp = 15;
        this.hp = 15;
        this.shield = 0;
    }

    public int stolenMoney=0;

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
                    battlegenerator_CS.hero_CS.SubstractHP(5 + strength - weak);
                    battlegenerator_CS.hero_CS.gold-= (5 + strength - weak);
                    this.stolenMoney+= (5 + strength - weak);
                    if (battlegenerator_CS.hero_CS.gold <= 0)
                        battlegenerator_CS.hero_CS.gold = 0;
                    break;
                case 2:
                    this.shield += (10 + dexterous - frail);
                    break;
                case 3:
                    this.hp = -10;
                    break;


            }
            this.CalculateMove();
        }
    }
    public bool blocked = false;
    public override void CalculateMove()
    {
        if (this.stolenMoney < 14)
            intent = 1;
        else if (!(blocked))
        {
            intent = 2;
        }
        else intent = 3;
    }


    public override string IntentText()
    {
        string text = "";
        switch (this.intent)
        {

            case 1:
                text = "Attack for an steal " + (int)(this.strength + 5 - this.weak);
                break;
            case 2:
                text = "Defend for " + (int)(this.dexterous + 10 - this.frail); ;
                break;
            case 3:
                text = "Lemme get outta here...";
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



