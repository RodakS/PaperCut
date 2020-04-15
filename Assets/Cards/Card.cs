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
        public string Description = "Deal 20 damage.";
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
        public string Name = "Block1";
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
    public class CardEnergy1 : MonoBehaviour
    {
        public int Id = 9;
        public string Name = "Energy1";
        public string Description = "Increase max energy by 2.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 3)
            {
                HeroUnit.maxenergy += 3;
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardPenetratingHit : MonoBehaviour
    {
        public int Id = 10;
        public string Name = "Penetrating hit";
        public string Description = "Deal 3 dmg that penetrate shield.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                EnemyUnit.HP -= 3;
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardSweepingEdge : MonoBehaviour
    {
        public int Id = 11;
        public string Name = "Sweeping edge";
        public string Description = "Deal 5 dmg to each enemy.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3) //Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
        {
            if (HeroUnit.energy >= 3)
            {
                EnemyUnit1.substractHP(5);
                EnemyUnit2.substractHP(5);
                EnemyUnit3.substractHP(5);
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardFinishingBlow : MonoBehaviour
    {
        public int Id = 12;
        public string Name = "Finishing blow";
        public string Description = "Deal 5 dmg, if enemy has below 30% max health, deal triple dmg.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 3)
            {
                if (EnemyUnit.HP < EnemyUnit.MaxHP * 30 / 100)
                {
                    EnemyUnit.substractHP(15);
                }
                else
                {
                    EnemyUnit.substractHP(5);
                }
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardFire : MonoBehaviour
    {
        public int Id = 13;
        public string Name = "Fire";
        public string Description = "Deal 5 dmg, set the target on fire for 3 turns.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                EnemyUnit.substractHP(5);
                EnemyUnit.SetOnFire = 3;
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardFiraga : MonoBehaviour
    {
        public int Id = 14;
        public string Name = "Firaga";
        public string Description = "Deal 5 dmg to each enemy, set the targets on fire for 3 turns.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3) //Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
        {
            if (HeroUnit.energy >= 3)
            {

                EnemyUnit1.substractHP(5);
                EnemyUnit2.substractHP(5);
                EnemyUnit3.substractHP(5);
                EnemyUnit1.SetOnFire = 3;
                EnemyUnit2.SetOnFire = 3;
                EnemyUnit3.SetOnFire = 3;
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardChloroform : MonoBehaviour
    {
        public int Id = 15;
        public string Name = "Chloroform";
        public string Description = "Puts the target to sleep for 2 turns.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                EnemyUnit.Sleep = 2;                
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardRegeneration : MonoBehaviour
    {
        public int Id = 16;
        public string Name = "Regeneration";
        public string Description = "Heal 3 dmg each turn for 3 turns.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                HeroUnit.HP += 3;
                if (HeroUnit.HP > HeroUnit.MaxHP)
                {
                    HeroUnit.HP = HeroUnit.MaxHP;
                }
                HeroUnit.Regeneration = 2;                
                HeroUnit.energy -= 2;                
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
}
public class CardTMP : MonoBehaviour
{
    public int Id = 4;
    public string Name = "Heal";
    public string Description = "Heal 5 dmg.";
    public int Cost = 1;
    public void Effect()
    {
    }


}
