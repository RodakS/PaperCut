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
            }
        }

        public void Turn(Hero Target)
        {
            switch (intent)
            {
                case 1:
                    //tutaj czekam aż zostanie stworzona instancja bohatera
                   Target.substractHP(6 + AttackUp);
                    break;
                case 2:
                    this.Shield += 10;
                    break;
                case 3:
                    this.Shield += 6;
                    this.AttackUp += 2;
                    break;


            }
           // this.Shield = 0;
            this.calculateMove(Target);
            //tutaj kończymy turę
        }

        public void calculateMove(Hero Target)
        {
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
         


    }



