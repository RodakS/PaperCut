
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jello : Enemy
{
    public Jello()
    {
        this.maxhp = 5;
        this.hp = 5;
        this.shield = 0;
        this.intent = -1;
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
                    battlegenerator_CS.hero_CS.SubstractHP(5 + strength - weak);
                    battlegenerator_CS.hero_CS.weak += 1;
                    battlegenerator_CS.hero_CS.frail += 1;
                    battlegenerator_CS.hero_CS.vulnerable += 1;
                    battlegenerator_CS.musicsystem_CS.PlayPukPuk();
                    break;


            }
            this.CalculateMove();
            if (this.stun > 0)
            {
                stun--;
                if (this.stun > 0)
                    this.intent = -1;
            }
        }
    }
    public bool blocked = false;
    public override void CalculateMove()
    {
            intent = 1;
    }


    public override string IntentText()
    {
        string text = "";
        switch (this.intent)
        {

            case 1:
                text = "I'ma blob you for " + (int)(this.strength + 5 - this.weak);
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



