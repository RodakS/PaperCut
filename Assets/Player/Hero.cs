using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Hero : MonoBehaviour
    {
        public int MaxHP = 80;
        public int HP = 80;
        public int AttackUp = 0;
        public int Shield=0;
        public int cardDraw = 5;
        public int maxenergy = 3;
        public int energy = 3;
        private const int maxCards = 10;
        public int Regeneration = 0;
        public int Gold = 0;
        public int AttackDown = 0;
        public int Vulnerable = 0;
    public int ShieldUp = 0;
    public int ShieldDown = 0;
    public int Bounty = 0;
    public int SetOnFire = 0;
    public int Sleep = 0;
    public int Stun = 0;

    void Start()
        {

        }
    public void Acquire(int gold)
    {
        this.Gold += gold;
    }

    public bool CheckCash(int check)
    {
        if (this.Gold >= check)
        { return true; }
        else return false;
    }
    public void Pay(int payment)
    {
        this.Gold -= payment;
    }

        public  void substractHP(int Damage)
        {
            if (Damage <= this.Shield)
            {
                this.Shield -= Damage;
            }
            else
            {
                Damage -= this.Shield;
                this.Shield = 0;
                this.HP -= Damage;
            }
        }

      

    public int TakeRandomModifier()
    {
        List<int> returnee = new List<int>();

        for (int i = 0; i < AttackUp; i++)
            returnee.Add(0);
        for (int i = 0; i < SetOnFire; i++)
            returnee.Add(1);
        for (int i = 0; i < Sleep; i++)
            returnee.Add(2);
        for (int i = 0; i < AttackDown; i++)
            returnee.Add(3);
        for (int i = 0; i < Vulnerable; i++)
            returnee.Add(4);
        for (int i = 0; i < ShieldUp; i++)
            returnee.Add(5);
        for (int i = 0; i < ShieldDown; i++)
            returnee.Add(6);
        for (int i = 0; i < Bounty; i++)
            returnee.Add(7);
        for (int i = 0; i < Stun; i++)
            returnee.Add(8);

        int randomInt = returnee[new System.Random().Next(0, returnee.Count)];
        switch (randomInt)
        {
            case 0:
                this.AttackUp--;
                break;
            case 1:
                this.SetOnFire--;
                break;
            case 2:
                this.Sleep--;
                break;
            case 3:
                this.AttackDown--;
                break;
            case 4:
                this.Vulnerable--;
                break;
            case 5:
                this.ShieldUp--;
                break;
            case 6:
                this.ShieldDown--;
                break;
            case 7:
                this.Bounty--;
                break;
            case 8:
                this.Stun--;

                break;
        }

        return randomInt;

    }
    public void GiveModifier(int modifier)
    {

        switch (modifier)
        {
            case 0:
                this.AttackUp++;
                break;
            case 1:
                this.SetOnFire++;
                break;
            case 2:
                this.Sleep++;
                this.energy = -1;
                break;
            case 3:
                this.AttackDown++;
                break;
            case 4:
                this.Vulnerable++;
                break;
            case 5:
                this.ShieldUp++;
                break;
            case 6:
                this.ShieldDown++;
                break;
            case 7:
                this.Bounty++;
                break;
            case 8:
                this.Stun++;
                this.energy = -1;
                break;
        }


    }






    void Update()
        {

        }
    }



