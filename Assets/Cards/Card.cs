using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaperCut
{
    //tutaj jest placeholder na mechanikę główną, niżej są już karty o które szymon prosił
    public class Card : MonoBehaviour
    {
        public int Id = 1;
        public string Name = "Attack";
        public string Description = "Deal 5 dmg.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit, int ID)
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
                        EnemyUnit.intent = -1;
                    }
                    break;

            }

        }

        
    }

    public class CardStun : MonoBehaviour
    {
        public int Id = 2;
        public string Name = "Stun";
        public string Description = "Stun and deal 5 dmg.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
           if( HeroUnit.energy>=3)
            {
                EnemyUnit.substractHP(5);
                EnemyUnit.intent = -1;
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }

            

        }


    }
    public class CardMaxHealth : MonoBehaviour
    {
        public int Id = 3;
        public string Name = "Health";
        public string Description = "Raise max health by 10";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                HeroUnit.HP += 10;
                HeroUnit.MaxHP += 10;
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }



        }


    }
    public class CardHeal : MonoBehaviour
    {
        public int Id = 4;
        public string Name = "Heal";
        public string Description = "Heal 5 dmg.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                HeroUnit.HP += 5;
                if (HeroUnit.HP > HeroUnit.MaxHP)
                    HeroUnit.HP = HeroUnit.MaxHP;
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }



        }


    }
    public class CardDamage1 : MonoBehaviour
    {
        public int Id = 5;
        public string Name = "Damage1";
        public string Description = "Deal 10 damage.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                EnemyUnit.substractHP(10);
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }



        }


    }
    public class CardDamage2 : MonoBehaviour
    {
        public int Id = 6;
        public string Name = "Damage2";
        public string Description = "Deal 10 damage.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                EnemyUnit.substractHP(20);
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }



        }


    }
    public class CardDamage3 : MonoBehaviour
    {
        public int Id = 7;
        public string Name = "Damage3";
        public string Description = "Deal 5 damage.";
        public int Cost = 0;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
           
                EnemyUnit.substractHP(5);
                //tutaj funkcja na ciągnięcie kolejnej karty
          



        }


    }
    public class CardBlock1 : MonoBehaviour
    {
        public int Id = 8;
        public string Name = "Block11";
        public string Description = "Block 10 damage.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                HeroUnit.Shield += 10;
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }



        }


    }
}
