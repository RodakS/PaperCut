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
                        EnemyUnit.substractHP(5+HeroUnit.AttackUp);
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
                        EnemyUnit.Stun = 1;
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
                EnemyUnit.Stun = 1;
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
    public class CardPanic : MonoBehaviour
    {
        public int Id = 17;
        public string Name = "Panic";
        public string Description = "Gain 8 shield, gain 2 Strength, Donate 2.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                HeroUnit.Shield += 8;
                //HeroUnit.Strength += 2;
                //Funkcja na danate'owanie            
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardShareTheWeakness : MonoBehaviour
    {
        public int Id = 18;
        public string Name = "Share the weakness";
        public string Description = "Gain 10 shield, gain 1 Weak, Donate 1.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                HeroUnit.Shield += 10;
                //HeroUnit.Strength -= 1;
                //Funkcja na danate'owanie            
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardQuestionableStab : MonoBehaviour
    {
        public int Id = 19;
        public string Name = "Questionable stab";
        public string Description = "Deal 9 damage, give the opponent 2 Weak, Steal 2.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                EnemyUnit.substractHP(9);
                //EnemyUnit.Strength -= 2;
                //Funkcja na steal'owanie            
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardGainTheUpperHand : MonoBehaviour
    {
        public int Id = 20;
        public string Name = "Gain the upper hand";
        public string Description = "Deal 7 damage, give the opponent 1 Strength, Steal 1.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                EnemyUnit.substractHP(7);
                //EnemyUnit.Strength += 1;
                //Funkcja na steal'owanie            
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardPickpocket : MonoBehaviour
    {
        public int Id = 21;
        public string Name = "Pickpocket";
        public string Description = "Deal 3 damage, Rob.";
        public int Cost = 0;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 0)
            {
                EnemyUnit.substractHP(3);
                HeroUnit.Gold += 3;                
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardDaylightRobbery : MonoBehaviour
    {
        public int Id = 22;
        public string Name = "Daylight Robbery";
        public string Description = "Deal 6 damage, Rob.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1)
            {
                EnemyUnit.substractHP(6);
                HeroUnit.Gold += 6;
                HeroUnit.energy -= 1;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardShoplift : MonoBehaviour
    {
        public int Id = 23;
        public string Name = "Shoplift";
        public string Description = "Deal 12 damage, Rob.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                EnemyUnit.substractHP(12);
                HeroUnit.Gold += 12;
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardTheGrandHeist : MonoBehaviour
    {
        public int Id = 24;
        public string Name = "The grand heist";
        public string Description = "Deal 10 damage to all enemies, Rob.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
        {
            if (HeroUnit.energy >= 3)
            {
                EnemyUnit1.substractHP(10);
                EnemyUnit2.substractHP(10);
                EnemyUnit3.substractHP(10);
                //switch (number of enemies)
                //{
                //    case 2:
                //        HeroUnit.Gold += 20;
                //        break;
                //    case 3:
                //        HeroUnit.Gold += 30;
                //        break;
                //    default:
                //        HeroUnit.Gold += 10;
                //        break;            
                //}
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardQuickMoney : MonoBehaviour
    {
        public int Id = 25;
        public string Name = "Quick money";
        public string Description = "Acquire 15, exhaust.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2)
            {
                HeroUnit.Gold += 15;                
                HeroUnit.energy -= 2;
                //Funkcja na exhaust'a
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardOneTimeChance : MonoBehaviour
    {
        public int Id = 26;
        public string Name = "One time chance";
        public string Description = "Acquire 200, fragile, if this card is in your hand at the end of your turn exhaust.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 3)
            {                
                HeroUnit.Gold += 200;
                HeroUnit.energy -= 3;
                //Funkcja na fragile'a
                //Funkcja na exhaust'a
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardSuddenBossfight : MonoBehaviour
    {
        public int Id = 27;
        public string Name = "Sudden bossfight";
        public string Description = "Stun the enemy, double his health, fully heal him, give him strength 10, Acquire 50 , Set his bounty 20.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 3)
            {
                EnemyUnit.Stun = 1;
                EnemyUnit.intent = -1;
                EnemyUnit.MaxHP = 2 * EnemyUnit.MaxHP;
                EnemyUnit.HP = EnemyUnit.MaxHP;
                HeroUnit.Gold += 50;
                //EnemyUnit.Bounty = 20;
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardGoldenSlash : MonoBehaviour
    {
        public int Id = 28;
        public string Name = "Golden Slash";
        public string Description = "Pay (your whole money), deal that much damage.";
        public int Cost = 3;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 3)
            {
                EnemyUnit.substractHP(HeroUnit.Gold);
                HeroUnit.Gold = 0;
                HeroUnit.energy -= 3;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardSilverSword : MonoBehaviour
    {
        public int Id = 29;
        public string Name = "Silver Sword";
        public string Description = "Deal 18 damage, Pay 8.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2 && HeroUnit.Gold >=8)
            {
                EnemyUnit.substractHP(18);
                HeroUnit.Gold -= 8;
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardAegisOfGold : MonoBehaviour
    {
        public int Id = 30;
        public string Name = "Aegis of gold";
        public string Description = "Pay 10, gain 20 shield.";
        public int Cost = 2;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 2 && HeroUnit.Gold >= 10)
            {
                HeroUnit.Gold -= 10;
                HeroUnit.Shield += 20;                
                HeroUnit.energy -= 2;
                //tutaj funkcja na ciągnięcie kolejnej karty
            }
        }
    }
    public class CardMoneyPunch : MonoBehaviour
    {
        public int Id = 31;
        public string Name = "Money punch";
        public string Description = "Pay 150, deal 8 damage, Acquire 150.";
        public int Cost = 1;
        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
        {
            if (HeroUnit.energy >= 1 && HeroUnit.Gold >= 150)
            {
                HeroUnit.Gold -= 150;
                EnemyUnit.substractHP(8);
                HeroUnit.Gold += 150;
                HeroUnit.energy -= 1;
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
