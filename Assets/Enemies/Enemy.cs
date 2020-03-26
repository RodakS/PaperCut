using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Enemy : MonoBehaviour
    {
        public int intent = 1;
        public int MaxHP = 80;
        public int HP = 80;
        public int AttackUp = 0;
        public int Shield;

        public void substractHP(int Damage)
        {
            if (Damage <= Shield)
            {
                Shield -= Damage;
            }
            else
            {
                Damage -= Shield;
                Shield = 0;
                HP -= Damage;
            }
        }

        public void Turn()
        {
            switch (intent)
            {
                case 1:
                    //tutaj czekam aż zostanie stworzona instancja bohatera
                   //  Hero.substractHP(6 + AttackUp);
                    break;
                case 2:
                    this.Shield += 10;
                    break;
                case 3:
                    this.Shield += 6;
                    this.AttackUp += 2;
                    break;


            }
            this.Shield = 0;
            this.calculateMove();
            //tutaj kończymy turę
        }

        public void calculateMove()
        {
            int AttackMove = 3;
            int DefenseMove = 6;
            //tutaj czekam aż zostanie stworzona instancja bohatera
            // if (Hero.HP < Hero.HP / 2) AttackMove++;
            if (this.HP < this.HP / 2) DefenseMove--;
            int Decision = Random.Range(0, 11);
            if (Decision < AttackMove)
                intent = 1;
            else if (Decision > DefenseMove)
                intent = 2;
            else intent = 3;
        }
         


    }



