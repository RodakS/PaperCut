using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaperCut
{
    public class CardAttack : MonoBehaviour
    {
        public int Id = 1;
        public string Name = "Attack";
        public string Description = "Deal 5 dmg.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit,Enemy EnemyUnit,int ID)
        {
            switch (ID)
            {
                case 1:
                    if (HeroUnit.energy >= 1)
                    {
                        EnemyUnit.substractHP(5);
                        HeroUnit.energy--;
                    }
                    break;
                case 2:
                    if (HeroUnit.energy >= 1)
                    {
                        HeroUnit.Shield += 5; ;
                        HeroUnit.energy--;
                    }
                    break;
                case 3:
                    if (HeroUnit.energy >= 2)
                    {
                        HeroUnit.AttackUp += 5;
                        HeroUnit.energy -= 2;
                    }
                    break;

            }
          
        }

        //przy użyciu zasób/energia/stanima bohatera spadłaby o 1
        //Hero.Resource -= CardAttack.Cost;

        //przy użyciu hp przeciwnika spadłoby o 5
        //CardAttack.Effect();

        //albo

        //public int Effect()
        //{
        //    int Damage = 5;
        //    return Damage;
        //}
        
        //Enemy.HP -= CardAttack.Effect();


        void Start()
        {

        }

        void Update()
        {

        }
    }
}
