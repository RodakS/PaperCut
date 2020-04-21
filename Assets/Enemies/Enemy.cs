using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Enemy : MonoBehaviour
    {
        public int intent = 1;
        public int MaxHP = 80;
        public int HP = 80;
        public int AttackUp = 0;
        public int Shield=0;
        public int SetOnFire = 0;
        public int Sleep = 0;
        public int AttackDown = 0;
        public int Vulnerable = 0;
        public int ShieldUp = 0;
        public int ShieldDown = 0;
        public int Bounty = 0;
        public int Stun = 0;
        public int Strength = 0;
        public int Weak = 0;
        public int Dexterous = 0;
        public int Frail = 0;

    public void substractHP(int Damage)
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
            if (this.intent == -2)
            {
                this.calculateMove(new Hero());
            }
        }
        }

        public void Turn(Hero Target)
    {
        if (this.SetOnFire > 0)
        {
            this.substractHP(3);
            this.SetOnFire--;
        }
        if (this.Sleep > 0)
        {
            this.intent = -2;
            this.Sleep--;
        }

        switch (intent)
            {
                case 1:
                    //tutaj czekam aż zostanie stworzona instancja bohatera
                   Target.substractHP(6 + AttackUp-AttackDown);
                    break;
                case 2:
                    this.Shield += (10+ShieldUp-ShieldDown);
                    break;
                case 3:
                    this.Shield += (6 + ShieldUp - ShieldDown);
                this.AttackUp += 2;
                    break;


            }
           // this.Shield = 0;
            this.calculateMove(Target);
            //tutaj kończymy turę
        }

        public void calculateMove(Hero Target)
        {
        Stun = 0;
        int AttackMove = 5;
        int DefenseMove = 8;
        //tutaj czekam aż zostanie stworzona instancja bohatera
        if (Target.HP < Target.HP / 2) AttackMove++;
        if (this.HP < this.HP / 2) DefenseMove--;
        int Decision = Random.Range(0, 11);
        if (Decision < AttackMove)
            intent = 1;
        else if (Decision > DefenseMove)
            intent = 2;
        else intent = 3;
        }

    public int TakeRandomModifier ()
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
        for (int i = 0; i < Strength; i++)
            returnee.Add(9);
        for (int i = 0; i < Weak; i++)
            returnee.Add(10);
        for (int i = 0; i < Dexterous; i++)
            returnee.Add(11);
        for (int i = 0; i < Frail; i++)
            returnee.Add(12);

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
                if (this.Sleep < 1)
                    this.calculateMove(new Hero());
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
                if (this.Stun < 1)
                    this.calculateMove(new Hero());
                break;            
            case 9:
                this.Strength--;
                break;
            case 10:
                this.Weak--;
                break;
            case 11:
                this.Dexterous--;
                break;
            case 12:
                this.Frail--;
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
                this.intent = -2;
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
                this.intent = -1;
                break;
            case 9:
                this.Strength++;
                break;
            case 10:
                this.Weak++;
                break;
            case 11:
                this.Dexterous++;
                break;
            case 12:
                this.Frail++;
                break;
        }
        

    }



}



