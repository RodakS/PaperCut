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
        public void Effect(Hero HeroUnit,Enemy EnemyUnit)
        {
            if (HeroUnit.energy > 1)
            {
                EnemyUnit.substractHP(5);
                HeroUnit.energy--;
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
