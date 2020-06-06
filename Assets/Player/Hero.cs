using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Hero : MonoBehaviour
    {
    public BattleGenerator battlegenerator_CS;
    public int maxhp = 80;
        public int hp = 80;
        public int shield=0;
        public int cardDraw = 5;
        public int maxenergy = 3;
        public int energy = 3;
        private const int maxCards = 10;
        public int regeneration = 0;
        public int gold = 0;
        public int vulnerable = 0;
        public int bounty = 0;
        public int setOnFire = 0;
        public int sleep = 0;
        public int stun = 0;
        public int strength = 0;
        public int weak = 0;
        public int dexterous = 0;
        public int frail = 0;

    void Start()
        {

        }
    public void AcquireGold(int goldGained)
    {
        this.gold += goldGained;
    }
    public void ResetEnergy()
    {

        if (this.regeneration > 0)
        {
            regeneration--;
            this.hp += this.regeneration;
            if (this.hp > this.maxhp)
                this.hp = this.maxhp;
        }
        if (this.setOnFire > 0)
        {
            setOnFire--;
            this.hp -= this.setOnFire;
        }
        if (this.sleep < 1 && this.stun < 1)
            this.energy = this.maxenergy;
        else
            this.energy = -1;
    }

    public bool IsDead()
    {
        if (this.hp <= 0)
            return true;
        else return false;
    }
    public bool CheckCash(int check)
    {
        if (this.gold >= check)
        { return true; }
        else return false;
    }
    public void Pay(int payment)
    {
        this.gold -= payment;
    }

        public  void SubstractHP(int damage)
        {
        damage += this.vulnerable;
            if (damage <= this.shield)
            {
                this.shield -= damage;
            }
            else
            {
                damage -= this.shield;
                this.shield = 0;
                this.hp -= damage;
            if (this.sleep>0)
            {
                this.sleep = 0;
            }
        }
        }

    public bool allModGreaterThan0()
    {
        int x = strength + weak + dexterous + frail + setOnFire + vulnerable + bounty + stun + sleep;
        if (x == 0)
            return false;
        else
            return true;
    }

    public int TakeRandomModifier()
    {
        if (allModGreaterThan0())

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
            randomInt = new System.Random().Next(0, returnee.Count);
            while (returnee[randomInt] < 1)
                randomInt = new System.Random().Next(0, returnee.Count);

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
                    break;
            }

            return randomInt;
        }
        else return -1;

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
                this.energy = -1;
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
                this.energy = -1;
                break;


        }
    }
    public int NumberOfMod()
    {
        int x = strength + weak + dexterous + frail + setOnFire + vulnerable + bounty + stun + sleep;
        return x;
    }






    
    }



