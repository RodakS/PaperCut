using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mała nieistniejąca zmiana
//tutaj jest placeholder na mechanikę główną, niżej są już karty o które szymon prosił
public class Card : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public BattleSystem bs;
    public int Id = 1;
    public string Name = "Attack";
    public string Description = "Deal 5 dmg.";
    public int Cost = 1;
    public void Effect(int ID)
    {
        switch (ID)
        {
            case 1:
                if (battlegenerator_CS.hero_CS.energy >= 1)
                {
                    battlegenerator_CS.hero_CS.energy--;
                    battlegenerator_CS.enemy_CS.SubstractHP(5 + battlegenerator_CS.hero_CS.strength);
                    battlegenerator_CS.hero_CS.energy--;
                }
                break;
            case 2:
                if (battlegenerator_CS.hero_CS.energy >= 1)
                {
                    battlegenerator_CS.hero_CS.shield += 5;
                    battlegenerator_CS.hero_CS.energy--;
                }
                break;
            case 3:
                if (battlegenerator_CS.hero_CS.energy >= 2)
                {
                    battlegenerator_CS.hero_CS.strength += 5;
                    battlegenerator_CS.hero_CS.energy -= 2;
                    battlegenerator_CS.enemy_CS.stun = 1;
                    battlegenerator_CS.enemy_CS.intent = -1;
                }
                break;

        }

    }


}

//    public class CardStun : MonoBehaviour
//    {
//        public int Id = 2;
//        public string Name = "Stun";
//        public string Description = "Stun and deal 5 dmg.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//           if( HeroUnit.energy>=3)
//            {
//                EnemyUnit.substractHP(5);
//                EnemyUnit.intent = -1;
//                HeroUnit.energy -= 3;
//                EnemyUnit.Stun = 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }

//    public class CardMaxHealth : MonoBehaviour
//    {
//        public Hero bs;
//        public int Id = 3;
//        public string Name = "Health";
//        public string Description = "Raise max health by 10";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {

//                HeroUnit.HP += 10;
//                HeroUnit.MaxHP += 10;
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }



//        }


//    }
//    public class CardHeal : MonoBehaviour
//    {
//        public int Id = 4;
//        public string Name = "Heal";
//        public string Description = "Heal 5 dmg.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                HeroUnit.HP += 5;
//                if (HeroUnit.HP > HeroUnit.MaxHP)
//                    HeroUnit.HP = HeroUnit.MaxHP;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }



//        }


//    }
//    public class CardDamage1 : MonoBehaviour
//    {
//        public int Id = 5;
//        public string Name = "Damage1";
//        public string Description = "Deal 10 damage.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                EnemyUnit.substractHP(10);
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }



//        }


//    }
//    public class CardDamage2 : MonoBehaviour
//    {
//        public int Id = 6;
//        public string Name = "Damage2";
//        public string Description = "Deal 20 damage.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit.substractHP(20);
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }



//        }


//    }
//    public class CardDamage3 : MonoBehaviour
//    {
//        public int Id = 7;
//        public string Name = "Damage3";
//        public string Description = "Deal 5 damage.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {

//                EnemyUnit.substractHP(5);
//                //tutaj funkcja na ciągnięcie kolejnej karty




//        }


//    }
//    public class CardBlock1 : MonoBehaviour
//    {
//        public int Id = 8;
//        public string Name = "Block1";
//        public string Description = "Block 10 damage.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                HeroUnit.Shield += 10;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }



//        }


//    }
//    public class CardEnergy1 : MonoBehaviour
//    {
//        public int Id = 9;
//        public string Name = "Energy1";
//        public string Description = "Increase max energy by 2.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                HeroUnit.maxenergy += 3;
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardPenetratingHit : MonoBehaviour
//    {
//        public int Id = 10;
//        public string Name = "Penetrating hit";
//        public string Description = "Deal 3 dmg that penetrate shield.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                EnemyUnit.HP -= 3;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardSweepingEdge : MonoBehaviour
//    {
//        public int Id = 11;
//        public string Name = "Sweeping edge";
//        public string Description = "Deal 5 dmg to each enemy.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3) //Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                EnemyUnit1.substractHP(5);
//                EnemyUnit2.substractHP(5);
//                EnemyUnit3.substractHP(5);
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFinishingBlow : MonoBehaviour
//    {
//        public int Id = 12;
//        public string Name = "Finishing blow";
//        public string Description = "Deal 5 dmg, if enemy has below 30% max health, deal triple dmg.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                if (EnemyUnit.HP < EnemyUnit.MaxHP * 30 / 100)
//                {
//                    EnemyUnit.substractHP(15);
//                }
//                else
//                {
//                    EnemyUnit.substractHP(5);
//                }
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFire : MonoBehaviour
//    {
//        public int Id = 13;
//        public string Name = "Fire";
//        public string Description = "Deal 5 dmg, set the target on fire for 3 turns.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit.substractHP(5);
//                EnemyUnit.SetOnFire = 3;
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFiraga : MonoBehaviour
//    {
//        public int Id = 14;
//        public string Name = "Firaga";
//        public string Description = "Deal 5 dmg to each enemy, set the targets on fire for 3 turns.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3) //Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
//        {
//            if (HeroUnit.energy >= 3)
//            {

//                EnemyUnit1.substractHP(5);
//                EnemyUnit2.substractHP(5);
//                EnemyUnit3.substractHP(5);
//                EnemyUnit1.SetOnFire = 3;
//                EnemyUnit2.SetOnFire = 3;
//                EnemyUnit3.SetOnFire = 3;
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardChloroform : MonoBehaviour
//    {
//        public int Id = 15;
//        public string Name = "Chloroform";
//        public string Description = "Puts the target to sleep for 2 turns.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit.Sleep = 2;                
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardRegeneration : MonoBehaviour
//    {
//        public int Id = 16;
//        public string Name = "Regeneration";
//        public string Description = "Heal 3 dmg each turn for 3 turns.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                HeroUnit.HP += 3;
//                if (HeroUnit.HP > HeroUnit.MaxHP)
//                {
//                    HeroUnit.HP = HeroUnit.MaxHP;
//                }
//                HeroUnit.Regeneration = 2;                
//                HeroUnit.energy -= 2;                
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardPanic : MonoBehaviour
//    {
//        public int Id = 17;
//        public string Name = "Panic";
//        public string Description = "Gain 8 shield, gain 2 Strength, Donate 2.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                HeroUnit.Shield += 8;
//                HeroUnit.Strength += 2;
//                //Enemy.GiveModifier(Hero.TakeRandomModifier);
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardShareTheWeakness : MonoBehaviour
//    {
//        public int Id = 18;
//        public string Name = "Share the weakness";
//        public string Description = "Gain 10 shield, gain 1 Weak, Donate 1.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                HeroUnit.Shield += 10;
//                HeroUnit.Weak += 1;
//                //Hero.GiveModifier(Enemy.TakeRandomModifier);
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardQuestionableStab : MonoBehaviour
//    {
//        public int Id = 19;
//        public string Name = "Questionable stab";
//        public string Description = "Deal 9 damage, give the opponent 2 Weak, Steal 2.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                EnemyUnit.substractHP(9);
//                EnemyUnit.Weak += 2;
//                //Enemy.GiveModifier(Hero.TakeRandomModifier);
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardGainTheUpperHand : MonoBehaviour
//    {
//        public int Id = 20;
//        public string Name = "Gain the upper hand";
//        public string Description = "Deal 7 damage, give the opponent 1 Strength, Steal 1.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit.substractHP(7);
//                EnemyUnit.Strength += 1;
//                //Enemy.GiveModifier(Hero.TakeRandomModifier);
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardPickpocket : MonoBehaviour
//    {
//        public int Id = 21;
//        public string Name = "Pickpocket";
//        public string Description = "Deal 3 damage, Rob.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0)
//            {
//                EnemyUnit.substractHP(3);
//                HeroUnit.Gold += 3;                
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardDaylightRobbery : MonoBehaviour
//    {
//        public int Id = 22;
//        public string Name = "Daylight Robbery";
//        public string Description = "Deal 6 damage, Rob.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                EnemyUnit.substractHP(6);
//                HeroUnit.Gold += 6;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardShoplift : MonoBehaviour
//    {
//        public int Id = 23;
//        public string Name = "Shoplift";
//        public string Description = "Deal 12 damage, Rob.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit.substractHP(12);
//                HeroUnit.Gold += 12;
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardTheGrandHeist : MonoBehaviour
//    {
//        public int Id = 24;
//        public string Name = "The grand heist";
//        public string Description = "Deal 10 damage to all enemies, Rob.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                EnemyUnit1.substractHP(10);
//                EnemyUnit2.substractHP(10);
//                EnemyUnit3.substractHP(10);
//                //switch (number of enemies)
//                //{
//                //    case 2:
//                //        HeroUnit.Gold += 20;
//                //        break;
//                //    case 3:
//                //        HeroUnit.Gold += 30;
//                //        break;
//                //    default:
//                //        HeroUnit.Gold += 10;
//                //        break;            
//                //}
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardQuickMoney : MonoBehaviour
//    {
//        public int Id = 25;
//        public string Name = "Quick money";
//        public string Description = "Acquire 15, exhaust.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                HeroUnit.Gold += 15;                
//                HeroUnit.energy -= 2;
//                //Funkcja na exhaust'a
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardOneTimeChance : MonoBehaviour
//    {
//        public int Id = 26;
//        public string Name = "One time chance";
//        public string Description = "Acquire 200, fragile, if this card is in your hand at the end of your turn exhaust.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3)
//            {                
//                HeroUnit.Gold += 200;
//                HeroUnit.energy -= 3;
//                //Funkcja na fragile'a
//                //Funkcja na exhaust'a
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardSuddenBossfight : MonoBehaviour
//    {
//        public int Id = 27;
//        public string Name = "Sudden bossfight";
//        public string Description = "Stun the enemy, double his health, fully heal him, give him strength 10, Acquire 50 , Set his bounty 20.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                EnemyUnit.Stun = 1;
//                EnemyUnit.intent = -1;
//                EnemyUnit.MaxHP = 2 * EnemyUnit.MaxHP;
//                EnemyUnit.HP = EnemyUnit.MaxHP;
//                HeroUnit.Gold += 50;
//                EnemyUnit.Bounty = 20;
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardGoldenSlash : MonoBehaviour
//    {
//        public int Id = 28;
//        public string Name = "Golden Slash";
//        public string Description = "Pay (your whole money), deal that much damage.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3)
//            {
//                EnemyUnit.substractHP(HeroUnit.Gold);
//                HeroUnit.Gold = 0;
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardSilverSword : MonoBehaviour
//    {
//        public int Id = 29;
//        public string Name = "Silver Sword";
//        public string Description = "Deal 18 damage, Pay 8.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2 && HeroUnit.Gold >=8)
//            {
//                EnemyUnit.substractHP(18);
//                HeroUnit.Gold -= 8;
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardAegisOfGold : MonoBehaviour
//    {
//        public int Id = 30;
//        public string Name = "Aegis of gold";
//        public string Description = "Pay 10, gain 20 shield.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2 && HeroUnit.Gold >= 10)
//            {
//                HeroUnit.Gold -= 10;
//                HeroUnit.Shield += 20;                
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardMoneyPunch : MonoBehaviour
//    {
//        public int Id = 31;
//        public string Name = "Money punch";
//        public string Description = "Pay 150, deal 8 damage, Acquire 150.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1 && HeroUnit.Gold >= 150)
//            {
//                HeroUnit.Gold -= 150;
//                EnemyUnit.substractHP(8);
//                HeroUnit.Gold += 150;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFairTrade : MonoBehaviour
//    {
//        public int Id = 32;
//        public string Name = "Fair Trade";
//        public string Description = "Pay 15, Steal 1, Give bounty 15.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0 && HeroUnit.Gold >= 15)
//            {
//                HeroUnit.Gold -= 15;
//                EnemyUnit.GiveModifier(HeroUnit.TakeRandomModifier());
//                EnemyUnit.Bounty = 20;           
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//}
//    public class CardMoneyIsPower : MonoBehaviour
//    {
//        public int Id = 33;
//        public string Name = "Money is Power";
//        public string Description = "Pay 300, gain 1 mana permanently.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3 && HeroUnit.Gold >= 300)
//            {
//                HeroUnit.Gold -= 15;
//                HeroUnit.maxenergy += 1;                   
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardBasicEconomy : MonoBehaviour
//    {
//        public int Id = 34;
//        public string Name = "Basic Economy";
//        public string Description = "Donate 1, Acquire 5.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0)
//            {
//                //Hero.GiveModifier(Enemy.TakeRandomModifier);
//                HeroUnit.Gold += 5;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardTargetPractice : MonoBehaviour
//    {
//        public int Id = 35;
//        public string Name = "Target practice";
//        public string Description = "Gain 8 shield, get a Bounty 5.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                HeroUnit.Shield += 8;
//                EnemyUnit.Bounty = 5;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFluidExchange : MonoBehaviour
//    {
//        public int Id = 36;
//        public string Name = "Fluid Exchange";
//        public string Description = "Pay 15, Deal 10 damage to an enemy, gain 10 shield, Steal 1, Donate 1, Rob, Exhaust.";
//        public int Cost = 3;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 3 && HeroUnit.Gold >= 15)
//            {
//                HeroUnit.Gold -= 15;
//                EnemyUnit.substractHP(10);
//                HeroUnit.Shield += 10;
//                //Enemy.GiveModifier(Hero.TakeRandomModifier);
//                //Hero.GiveModifier(Enemy.TakeRandomModifier);
//                HeroUnit.Gold += 10;
//                //Funkcja na exhaust'a                
//                HeroUnit.energy -= 3;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardBastion : MonoBehaviour
//    {
//        public int Id = 37;
//        public string Name = "Bastion";
//        public string Description = "Gain 1 Dexterous, gain 6 shieldy.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {                
//                HeroUnit.Dexterous = 1;
//                HeroUnit.Shield += 6;
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardOneForAll : MonoBehaviour
//    {
//        public int Id = 38;
//        public string Name = "One for all";
//        public string Description = "Get 2 vulnerable, 2 Frail and 2 Weak, Donate 6.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 2 && HeroUnit.Gold >= 6)
//            {
//                HeroUnit.Vulnerable += 2;
//                HeroUnit.Frail += 2;
//                HeroUnit.Strength += 2;
//                HeroUnit.Gold -= 6;            
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardAllForOne : MonoBehaviour
//    {
//        public int Id = 39;
//        public string Name = "All for one";
//        public string Description = "Give 1 strength, 1 dexterous to all enemies, steal 2 from each.";
//        public int Cost = 2;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit1, Enemy EnemyUnit2, Enemy EnemyUnit3)
//        {
//            if (HeroUnit.energy >= 2)
//            {
//                EnemyUnit1.Strength += 2;
//                EnemyUnit2.Strength += 2;
//                EnemyUnit3.Strength += 2;
//                EnemyUnit1.Dexterous += 2;
//                EnemyUnit2.Dexterous += 2;
//                EnemyUnit3.Dexterous += 2;
//                //Funkcja na steal'owanie z kilku celów
//                //Enemy.GiveModifier(Hero.TakeRandomModifier);
//                HeroUnit.energy -= 2;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardBasicMovements : MonoBehaviour
//    {
//        public int Id = 40;
//        public string Name = "Basic Movements";
//        public string Description = "Deal 1 damage, get 1 shield, get 1 strength and 1 dexterous for the rest of this turn.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0)
//            {                
//                EnemyUnit.substractHP(1);
//                HeroUnit.Shield += 1;
//                HeroUnit.Strength += 1;                
//                HeroUnit.Dexterous = 1;                
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFinishingThrust : MonoBehaviour
//    {
//        public int Id = 41;
//        public string Name = "Finishing thrust";
//        public string Description = "Deal 2 damage per modifier an enemy has.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                //if (EnemyUnit.NumberOfModifiers >= 0)
//                //{
//                //    EnemyUnit.substractHP(2 * EnemyUnit.NumberOfModifiers);
//                //}
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardFinalDefence : MonoBehaviour
//    {
//        public int Id = 42;
//        public string Name = "Final Defence";
//        public string Description = "get 3 shield per modifier you have.";
//        public int Cost = 1;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 1)
//            {
//                //if (HeroUnit.NumberOfModifiers >= 0)
//                //{
//                //    HeroUnit.Shield += 3 * HeroUnit.NumberOfModifiers;
//                //}
//                HeroUnit.energy -= 1;
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardGamblingHeart : MonoBehaviour
//    {
//        public int Id = 43;
//        public string Name = "Gambling Heart";
//        public string Description = "Get 3 shield and 1 random modifier.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0)
//            {
//                HeroUnit.Shield += 3;
//                //funkcja dająca bohaterowi randomowy modifier
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }
//    public class CardAceInTheHole : MonoBehaviour
//    {
//        public int Id = 44;
//        public string Name = "Ace in the hole";
//        public string Description = "Deal 3 damage and give 1 random modifier.";
//        public int Cost = 0;
//        public void Effect(Hero HeroUnit, Enemy EnemyUnit)
//        {
//            if (HeroUnit.energy >= 0)
//            {
//                EnemyUnit.substractHP(3);                
//                //funkcja dająca wrogowi randomowy modifier
//                //tutaj funkcja na ciągnięcie kolejnej karty
//            }
//        }
//    }



//public class CardTMP : MonoBehaviour
//{
//    public int Id = 4;
//    public string Name = "Heal";
//    public string Description = "Heal 5 dmg.";
//    public int Cost = 1;
//    public void Effect()
//    {
//    }


//}
