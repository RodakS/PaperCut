using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OblivionOrb : Enemy
{
    public OblivionOrb()
    {
        this.maxhp = 60;
        this.hp = 60;
        this.shield = 10;
        this.intent = 0;
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
                case 0:
                    battlegenerator_CS.enemyGenerator_CS.GenereateOrbUnderlings();
                    battlegenerator_CS.hero_CS.hp = 80;
                    break;
                case 1:
                    battlegenerator_CS.enemyGenerator_CS.GenereateOrbUnderlings();
                    break;
                case 2:
                    battlegenerator_CS.hero_CS.SubstractHP(8 + strength - weak);
                    this.strength += 1;
                    break;
                case 3:
                    battlegenerator_CS.hero_CS.SubstractHP(3 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(3 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(3 + strength - weak);

                    break;


            }
            this.CalculateMove();
        }
    }

    public override void CalculateMove()
    {
        if (battlegenerator_CS.enemy_CS2.IsDead() && battlegenerator_CS.enemy_CS.IsDead())
        {
            intent = 1;
        }
        else if (this.hp > 30)
            intent = 2;
        else
            intent = 3;
    }


    public override string IntentText()
    {
        string text = "";
        switch (this.intent)
        {
            case 0:
                text = "Awaken, my underlings !";
                break;

            case 1:
                text = "Awaken, my underlings !";
                break;
            case 2:
                text = "Attack for " + (int)(this.strength + 5) + ", 1 strength up.";
                break;
            case 3:
                text = "Attack three times for " + (int)(this.strength + 3 - this.weak);
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



