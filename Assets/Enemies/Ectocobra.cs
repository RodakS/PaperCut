﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ectocobra : Enemy
{
    public Ectocobra()
    {
        this.maxhp = 10;
        this.hp = 10;
        this.shield = 5;
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
                    battlegenerator_CS.hero_CS.SubstractHP(1 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(1 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(1 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(1 + strength - weak);
                    battlegenerator_CS.hero_CS.SubstractHP(1 + strength - weak);
                    battlegenerator_CS.musicsystem_CS.PlayPukPuk();
                    break;
                case 2:
                    this.shield += (1 + dexterous - frail);
                    this.shield += (1 + dexterous - frail);
                    this.shield += (1 + dexterous - frail);
                    this.shield += (1 + dexterous - frail);
                    this.shield += (1 + dexterous - frail);
                    battlegenerator_CS.musicsystem_CS.PlayPukPuk();
                    break;
                case 3:
                    this.strength += 2;
                    this.dexterous += 2;
                    battlegenerator_CS.musicsystem_CS.PlayKlang();
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
                text = "Attack five times for " + (int)(this.strength + 1- this.weak) ;
                break;
            case 2:
                text = "Defend five times for" + (int)(this.dexterous + 1 - this.frail); ;
                break;
            case 3:
                text = "2 strength up, 2 dexterous up";
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



