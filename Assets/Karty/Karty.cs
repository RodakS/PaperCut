using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStun : CardTemplate
{
    public override void Replace()
    {
        cardName = "Stun";
        cardDescription = "Stun and deal 10 dmg.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Stun (Enemy, 1) 
        battlegenerator_CS.enemy_CS.SubstractHP(10);        
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardHealth : CardTemplate
{
    public override void Replace()
    {
        cardName = "Health";
        cardDescription = "Raise max health by 10.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.maxhp += 10;
        battlegenerator_CS.hero_CS.hp += 10;        
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardHeal : CardTemplate
{
    public override void Replace()
    {
        cardName = "Heal";
        cardDescription = "Heal 5 dmg.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.hp += 5;
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardDamage1 : CardTemplate
{
    public override void Replace()
    {
        cardName = "Damage1";
        cardDescription = "Deal 5 damage.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(5);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardDamage2 : CardTemplate
{
    public override void Replace()
    {
        cardName = "Damage2";
        cardDescription = "Deal 10 damage.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(10);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardDamage3 : CardTemplate
{
    public override void Replace()
    {
        cardName = "Damage3";
        cardDescription = "Deal 20 damage.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(20);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardBlock1 : CardTemplate
{
    public override void Replace()
    {
        cardName = "Block1";
        cardDescription = "Block 10 damage.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.shield += 10;
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardEnergy1 : CardTemplate
{
    public override void Replace()
    {
        cardName = "Energy1";
        cardDescription = "Increase max energy by 2.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.maxenergy += 2;
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardPenetratingHit : CardTemplate
{
    public override void Replace()
    {
        cardName = "Penetrating hit";
        cardDescription = "Deal 3 dmg that penetrate shield.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.hp -= 3;
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardSweepingEdge : CardTemplate
{
    public override void Replace()
    {
        cardName = "Sweeping edge";
        cardDescription = "Deal 5 dmg to each enemy.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //battlegenerator_CS.enemy1_CS.substractHP(5);
        //battlegenerator_CS.enemy2_CS.substractHP(5);
        //battlegenerator_CS.enemy3_CS.substractHP(5);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFinishingBlow : CardTemplate
{
    public override void Replace()
    {
        cardName = "Finishing blow";
        cardDescription = "Deal 5 dmg, if enemy has below 30% max health, deal triple dmg.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.enemy_CS.hp < battlegenerator_CS.enemy_CS.maxhp * 30 / 100)
        {
            battlegenerator_CS.enemy_CS.SubstractHP(15);
        }
        else
        {
            battlegenerator_CS.enemy_CS.SubstractHP(5);
        }
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFire : CardTemplate
{
    public override void Replace()
    {
        cardName = "Fire";
        cardDescription = "Deal 5 dmg, set the target on fire for 3 turns.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(5);
        //Set on fire (Enemy, 3, 3)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFiraga : CardTemplate
{
    public override void Replace()
    {
        cardName = "Firaga";
        cardDescription = "Deal 5 dmg to each enemy, set the targets on fire for 3 turns.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //battlegenerator_CS.enemy1_CS.substractHP(5);
        //battlegenerator_CS.enemy2_CS.substractHP(5);
        //battlegenerator_CS.enemy3_CS.substractHP(5);
        //Set on fire (Enemy, 3, 3)
        //Set on fire (Enemy, 3, 3)
        //Set on fire (Enemy, 3, 3)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardChloroform : CardTemplate
{
    public override void Replace()
    {
        cardName = "Chloroform";
        cardDescription = "Puts the target to sleep for 2 turns.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Sleep (Enemy, 2)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardRegeneration : CardTemplate
{
    public override void Replace()
    {
        cardName = "Regeneration";
        cardDescription = "Heal 3 dmg each turn for 3 turns.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Regeneration (Hero, 3, 3)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardPanic : CardTemplate
{
    public override void Replace()
    {
        cardName = "Panic";
        cardDescription = "Gain 8 shield, gain 2 Strength, Donate 2.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.shield += 8;
        //Strength (Hero, 2)
        //Donate (Hero, Enemy, 2)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardShareTheWeakness : CardTemplate
{
    public override void Replace()
    {
        cardName = "Share the weakness";
        cardDescription = "Gain 10 shield, gain 1 Weak, Donate 1.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.shield += 10;
        //Weak (Hero, 1)
        //Donate (Hero, Enemy, 1)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardQuestionableStab : CardTemplate
{
    public override void Replace()
    {
        cardName = "Questionable stab";
        cardDescription = "Deal 9 damage, give the opponent 2 Weak, Steal 2.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(9);
        //Weak (Enemy, 2)
        //Steal (Hero, Enemy, 2)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardGainTheUpperHand : CardTemplate
{
    public override void Replace()
    {
        cardName = "Gain the upper hand";
        cardDescription = "Deal 7 damage, give the opponent 1 Strength, Steal 1.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(7);
        //Strength (Enemy, 1)
        //Steal (Hero, Enemy, 1)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardPickpocket : CardTemplate
{
    public override void Replace()
    {
        cardName = "Pickpocket";
        cardDescription = "Deal 3 damage, Rob.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.enemy_CS.HP;
        battlegenerator_CS.enemy_CS.SubstractHP(3);
        //x2 = battlegenerator_CS.enemy_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardDaylightRobbery : CardTemplate
{
    public override void Replace()
    {
        cardName = "Daylight Robbery";
        cardDescription = "Deal 6 damage, Rob.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.enemy_CS.HP;
        battlegenerator_CS.enemy_CS.SubstractHP(6);
        //x2 = battlegenerator_CS.enemy_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardShoplift : CardTemplate
{
    public override void Replace()
    {
        cardName = "Shoplift";
        cardDescription = "Deal 12 damage, Rob.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.enemy_CS.HP;
        battlegenerator_CS.enemy_CS.SubstractHP(12);
        //x2 = battlegenerator_CS.enemy_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardTheGrandHeist : CardTemplate
{
    public override void Replace()
    {
        cardName = "The grand heist";
        cardDescription = "Deal 10 damage to all enemies, Rob.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.enemy1_CS.HP;
        //battlegenerator_CS.enemy1_CS.substractHP(12);
        //x2 = battlegenerator_CS.enemy1_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob

        //x1 = battlegenerator_CS.enemy2_CS.HP;
        //battlegenerator_CS.enemy2_CS.substractHP(12);
        //x2 = battlegenerator_CS.enemy2_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob

        //x1 = battlegenerator_CS.enemy3_CS.HP;
        //battlegenerator_CS.enemy3_CS.substractHP(12);
        //x2 = battlegenerator_CS.enemy3_CS.HP;
        //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
        //rob

        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardQuickMoney : CardTemplate
{
    public override void Replace()
    {
        cardName = "Quick money";
        cardDescription = "Acquire 15, exhaust.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {        
        battlegenerator_CS.hero_CS.gold += 15;
        //Exhaust
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardOneTimeChance : CardTemplate
{
    public override void Replace()
    {
        cardName = "One time chance";
        cardDescription = "Acquire 200, fragile, if this card is in your hand at the end of your turn exhaust.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.gold += 200;
        //Fragile
        //Exhaust
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardSuddenBossfight : CardTemplate
{
    public override void Replace()
    {
        cardName = "Sudden bossfight";
        cardDescription = "Stun the enemy, double his health, fully heal him, give him strength 10, Acquire 50 , Set his bounty 20.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Stun (Enemy, 1)
        battlegenerator_CS.enemy_CS.maxhp *= 2;
        battlegenerator_CS.enemy_CS.hp = battlegenerator_CS.enemy_CS.maxhp;
        //Stength (Enemy, 10)
        battlegenerator_CS.hero_CS.gold += 50;
        //Bounty (Enemy, 20)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardGoldenSlash : CardTemplate
{
    public override void Replace()
    {
        cardName = "Golden Slash";
        cardDescription = "Pay (your whole money), deal that much damage.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(battlegenerator_CS.hero_CS.gold);
        battlegenerator_CS.hero_CS.gold = 0;        
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardSilverSword : CardTemplate
{
    public override void Replace()
    {
        cardName = "Silver Sword";
        cardDescription = "Deal 18 damage, Pay 8.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 8)
        {
            battlegenerator_CS.enemy_CS.SubstractHP(18);
            battlegenerator_CS.hero_CS.gold -= 8;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

public class CardAegisOfGold : CardTemplate
{
    public override void Replace()
    {
        cardName = "Aegis of gold";
        cardDescription = "Pay 10, gain 20 shield.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 10)
        {
            battlegenerator_CS.hero_CS.shield += 20;
            battlegenerator_CS.hero_CS.gold -= 10;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }        
    }
}

public class CardMoneyPunch : CardTemplate
{
    public override void Replace()
    {
        cardName = "Money punch";
        cardDescription = "Pay 150, deal 8 damage, Acquire 150.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 150)
        {
            battlegenerator_CS.hero_CS.gold -= 150;
            battlegenerator_CS.enemy_CS.SubstractHP(8);            
            battlegenerator_CS.hero_CS.gold += 150;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

public class CardFairTrade : CardTemplate
{
    public override void Replace()
    {
        cardName = "Fair Trade";
        cardDescription = "Pay 15, Steal 1, Give bounty 15.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 15)
        {
            battlegenerator_CS.hero_CS.gold -= 15;
            //Steal (Hero, Enemy, 1)
            //Bounty (Enemy, 15)
            battlegenerator_CS.enemy_CS.SubstractHP(8);
            battlegenerator_CS.hero_CS.gold += 150;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

public class CardMoneyIsPower : CardTemplate
{
    public override void Replace()
    {
        cardName = "Money is Power";
        cardDescription = "Pay 300, gain 1 mana permanently.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 300)
        {
            battlegenerator_CS.hero_CS.gold -= 300;
            battlegenerator_CS.hero_CS.maxenergy += 2;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

public class CardBasicEconomy : CardTemplate
{
    public override void Replace()
    {
        cardName = "Basic Economy";
        cardDescription = "Donate 1, Acquire 5.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Donate (Hero, Enemy, 1)
        battlegenerator_CS.hero_CS.gold += 5;        
        battlegenerator_CS.hero_CS.energy -= cardCost;
        
    }
}

public class CardTargetPractice : CardTemplate
{
    public override void Replace()
    {
        cardName = "Target practice";
        cardDescription = "Gain 8 shield, get a Bounty 5.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Donate (Hero, Enemy, 1)
        //Bounty (Hero, 5)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFluidExchange : CardTemplate
{
    public override void Replace()
    {
        cardName = "Fluid Exchange";
        cardDescription = "Pay 15, Deal 10 damage to an enemy, gain 10 shield, Steal 1, Donate 1, Rob, Exhaust.";
        cardCost = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 15)
        {
            battlegenerator_CS.hero_CS.gold -= 15;

            //int x1, x2;
            //x1 = battlegenerator_CS.enemy_CS.HP;
            battlegenerator_CS.enemy_CS.SubstractHP(10);
            //x2 = battlegenerator_CS.enemy_CS.HP;
            //battlegenerator_CS.hero_CS.Gold += (x2 - x1);    
            //rob

            battlegenerator_CS.hero_CS.shield += 10;
            //Steal (Hero, Enemy, 1)
            //Donate (Hero, Enemy, 1)
            //Exhaust
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

public class CardBastion : CardTemplate
{
    public override void Replace()
    {
        cardName = "Bastion";
        cardDescription = "Gain 1 Dexterous, gain 6 shieldy.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Dexterous (Hero, 1)
        battlegenerator_CS.hero_CS.shield += 6;        
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardOneForAll : CardTemplate
{
    public override void Replace()
    {
        cardName = "One for all";
        cardDescription = "Get 2 vulnerable, 2 Frail and 2 Weak, Donate 6.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Vulnerable (Hero, 2)
        //Frail (Hero, 2)
        //Weak (Hero, 2)
        //Donate (Hero, Enemy, 6)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardAllForOne : CardTemplate
{
    public override void Replace()
    {
        cardName = "All for one";
        cardDescription = "Give 1 strength, 1 dexterous to all enemies, steal 2 from each.";
        cardCost = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Strength (Enemy1, 1)
        //Strength (Enemy2, 1)
        //Strength (Enemy3, 1)
        //Dexterous (Enemy1, 1)
        //Dexterous (Enemy2, 1)
        //Dexterous (Enemy3, 1)
        //Steal (Hero, Enemy1, 2)
        //Steal (Hero, Enemy2, 2)
        //Steal (Hero, Enemy3, 2)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardBasicMovements : CardTemplate
{
    public override void Replace()
    {
        cardName = "Basic Movements";
        cardDescription = "Deal 1 damage, get 1 shield, get 1 strength and 1 dexterous for the rest of this turn.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(1);
        battlegenerator_CS.hero_CS.shield += 1;
        //Strength (Hero, 1)
        //Dexterous (Hero, 1)        
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFinishingThrust : CardTemplate
{
    public override void Replace()
    {
        cardName = "Finishing thrust";
        cardDescription = "Deal 2 damage per modifier an enemy has.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //battlegenerator_CS.enemy_CS.substractHP(2 * battlegenerator_CS.enemy_CS.NumberOfModifiers);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardFinalDefence : CardTemplate
{
    public override void Replace()
    {
        cardName = "Final Defence";
        cardDescription = "Get 3 shield per modifier you have.";
        cardCost = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //battlegenerator_CS.hero_CS.Shield += 3 * battlegenerator_CS.hero_CS.NumberOfModifiers;
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardGamblingHeart : CardTemplate
{
    public override void Replace()
    {
        cardName = "Gambling Heart";
        cardDescription = "Get 3 shield and 1 random modifier.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.hero_CS.shield += 3;
        //GetRandom Modifier (Hero, 1)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class CardAceInTheHole : CardTemplate
{
    public override void Replace()
    {
        cardName = "Ace in the hole";
        cardDescription = "Deal 3 damage and give 1 random modifier.";
        cardCost = 0;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(3);        
        //GetRandom Modifier (Enemy, 1)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}













































