using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Hero : MonoBehaviour
    {
        public int MaxHP = 80;
        public int HP = 80;
        public int AttackUp = 0;
        public int Shield;
        public int cardDraw = 5;
        public int energy = 3;
        private const int maxCards = 10;
        void Start()
        {

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

        public void Turn()
        {
            
            //tutaj mechanika zagrywania kart
            //ciągnij cardDraw kart, ale nie więcej niż maxCards
            //dopóki endTurn nie naciśnięte róbta rzeczy
            //tutaj kończymy turę
        }

        
         



    void Update()
        {

        }
    }



