using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
    {

    public Text enemyHP;
    public Text enemyShield;
    public Text enemyStrength;
    public Text intentText;
    public BattleGenerator battlegenerator_CS;
    public int intent = 1;
        public int maxhp = 80;
        public int hp = 80;
        public int shield=0;
        public int setOnFire = 0;
        public int sleep = 0;
        public int vulnerable = 0;
        public int bounty = 0;
        public int stun = 0;
        public int strength = 0;
        public int weak = 0;
        public int dexterous = 0;
    public bool isDed = false;
        public int frail = 0;

    public void SubstractHP(int Damage)
        {
            if (Damage <= this.shield)
            {
            this.shield -= Damage;
            }
            else
            {
                Damage -= this.shield;
                this.shield = 0;
                this.hp -= Damage;
            if (this.intent == -2)
            {
                this.CalculateMove();
            }
        }
        }

        public virtual void ExecuteTurn()
    {
        if (!(this.isDed))
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

        public virtual void CalculateMove()
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

    public int TakeRandomModifier ()
    {
        List<int> returnee = new List<int>();

        returnee.Add(this.strength);
        returnee.Add(this.setOnFire);
        returnee.Add(this.sleep);
        returnee.Add(this.weak);
        returnee.Add(this.vulnerable);
        returnee.Add(this.dexterous);
        returnee.Add(this.frail);
        returnee.Add(this.bounty);
        returnee.Add(this.stun);

        int randomInt = 0;
        while (randomInt<1)
            randomInt = returnee[new System.Random().Next(0, returnee.Count)];


        switch (randomInt)
        {
            case 0:
                this.strength--;
                break;
            case 1:
                this.setOnFire--;
                break;
            case 2:
                this.sleep--;
                if (this.sleep < 1)
                    this.CalculateMove();
                break;
            case 3:
                this.weak--;
                break;
            case 4:
                this.vulnerable--;
                break;
            case 5:
                this.dexterous--;
                break;
            case 6:
                this.frail--;
                break;
            case 7:
                this.bounty--;
                break;
            case 8:
                this.stun--;
                if (this.stun < 1)
                    this.CalculateMove();
                break;         
        }

        return randomInt;

    }
    public void GiveModifier(int modifier)
    {

        switch (modifier)
        {
            case 0:
                this.strength++;
                break;
            case 1:
                this.setOnFire++;
                break;
            case 2:
                this.sleep++;
                this.intent=-2;
                break;
            case 3:
                this.weak++;
                break;
            case 4:
                this.vulnerable++;
                break;
            case 5:
                this.dexterous++;
                break;
            case 6:
                this.frail++;
                break;
            case 7:
                this.bounty++;
                break;
            case 8:
                this.stun++;
                this.intent=-1;
                break;
        }


    }

    public virtual string IntentText()
    {
        string text="";
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
    public void UpdateEnemyHUD()
    {
        enemyHP.text = this.hp + "/" + this.maxhp;
        enemyShield.text = "Shield: " + this.shield;
        enemyStrength.text = "Strength : " + this.strength;
        intentText.text = this.IntentText();
    }

    public Enemy copyIntoThis(Enemy copiedFrom)
    {
        this.intentText = copiedFrom.intentText;
        this.enemyHP = copiedFrom.enemyHP;
        this.enemyShield = copiedFrom.enemyShield;
        this.enemyStrength = copiedFrom.enemyStrength;
        this.battlegenerator_CS = copiedFrom.battlegenerator_CS;
        return this;
    }

   

}



