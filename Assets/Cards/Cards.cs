using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardStun : CardTemplate
{
    public override void Replace()
    {
        cardName = "Stun";
        cardDescription = "Stun and deal 10 dmg.";
        cardCost = 3;
        cardSprite = Resources.Load<Sprite>("Stun_2");
        this.requiresTarget = true;

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            cardCost = 2;
        }
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
       
            //Stun (Enemy, 1) 
            battlegenerator_CS.targetedEnemy.SubstractHP(10);
            battlegenerator_CS.hero_CS.energy -= cardCost;
        
    }
}

public class CardHealth : CardTemplate
{
    public override void Replace()
    {
        int healthUp = 10;
        cardName = "Health";
        cardDescription = "Raise max health by " + healthUp + ".";
        cardCost = 2;
        cardSprite = Resources.Load<Sprite>("Health_2");

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            healthUp = 15;
        }
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
        int healUp = 5;
        cardName = "Heal";
        cardDescription = "Heal " + healUp +" dmg.";
        cardCost = 1;
        cardSprite = Resources.Load<Sprite>("Heal_2");

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            healUp = 10;
        }
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
        int damageUp = 5;
        cardName = "Damage1";
        cardDescription = "Deal 5 damage.";
        cardCost = 0;
        cardSprite = Resources.Load<Sprite>("Damage1_2");
        this.requiresTarget = true;

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            damageUp = 10;
        }
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        
            battlegenerator_CS.targetedEnemy.SubstractHP(5);
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
        cardSprite = Resources.Load<Sprite>("Damage2_2");
        this.requiresTarget = true;

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            cardCost = 0;
        }
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        
            battlegenerator_CS.targetedEnemy.SubstractHP(10);
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
        cardSprite = Resources.Load<Sprite>("Damage3_2");
        this.requiresTarget = true;

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            cardCost = 1;
        }
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(20);
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
        cardSprite = Resources.Load<Sprite>("Block1_2");

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            cardCost = 0;
        }
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
        //cardSprite = Resources.Load<Sprite>("Damage1_2");

        if (isUpgraded == 1)
        {
            cardName = cardName + "+";
            cardCost = 2;
        } //TODO upgrade dla pozostalych kart
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("PenetratingHit_2");   // <- tak zrobić do reszty kart
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.hp -= 3;
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
        cardSprite = Resources.Load<Sprite>("SweepingEdge_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(5);
        battlegenerator_CS.enemy_CS2.SubstractHP(5);
        battlegenerator_CS.enemy_CS3.SubstractHP(5);
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("FinishingBlow_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.targetedEnemy.hp < battlegenerator_CS.targetedEnemy.maxhp * 30 / 100)
        {
            battlegenerator_CS.targetedEnemy.SubstractHP(15);
        }
        else
        {
            battlegenerator_CS.targetedEnemy.SubstractHP(5);
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("Fire_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(5);
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
        cardSprite = Resources.Load<Sprite>("Firaga_2");
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("Chloroform_2");
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
        cardSprite = Resources.Load<Sprite>("Regeneration_2");
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("Panic_2");
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("ShareTheWeakness_2");
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("QuestionableStab_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(9);
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("GainTheUpperHand_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(7);
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("Pickpocket_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.targetedEnemy.HP;
        battlegenerator_CS.targetedEnemy.SubstractHP(3);
        //x2 = battlegenerator_CS.targetedEnemy.HP;
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("DaylightRobbery_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.targetedEnemy.HP;
        battlegenerator_CS.targetedEnemy.SubstractHP(6);
        //x2 = battlegenerator_CS.targetedEnemy.HP;
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("Shoplift_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //int x1, x2;
        //x1 = battlegenerator_CS.targetedEnemy.HP;
        battlegenerator_CS.targetedEnemy.SubstractHP(12);
        //x2 = battlegenerator_CS.targetedEnemy.HP;
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
        cardSprite = Resources.Load<Sprite>("TheGrandHeist_2");
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
        cardSprite = Resources.Load<Sprite>("QuickMoney_2");
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
        cardSprite = Resources.Load<Sprite>("OneTimeChance_2");
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("SuddenBossFight_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //Stun (Enemy, 1)
        battlegenerator_CS.targetedEnemy.maxhp *= 2;
        battlegenerator_CS.targetedEnemy.hp = battlegenerator_CS.targetedEnemy.maxhp;
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
        this.requiresTarget = true;
        cardName = "Golden Slash";
        cardDescription = "Pay (your whole money), deal that much damage.";
        cardCost = 3;
        cardSprite = Resources.Load<Sprite>("GoldenSlash_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(battlegenerator_CS.hero_CS.gold);
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
        this.requiresTarget = true;
        cardSprite = Resources.Load<Sprite>("SilverSword_2");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 8)
        {
            battlegenerator_CS.targetedEnemy.SubstractHP(18);
            battlegenerator_CS.hero_CS.gold -= 8;
            battlegenerator_CS.hero_CS.energy -= cardCost;
        }
    }
}

//---------------------------------------------
//Do tych nie ma jeszcze artów - trzeba je wkleić do Assetów

public class CardAegisOfGold : CardTemplate
{
    public override void Replace()
    {
        cardName = "Aegis of gold";
        cardDescription = "Pay 10, gain 20 shield.";
        cardCost = 2;
        cardSprite = Resources.Load<Sprite>("Aegis_Of_Gold");
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
        this.requiresTarget = true;
        cardCost = 1;
        cardSprite = Resources.Load<Sprite>("Money_Punch");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 150)
        {
            battlegenerator_CS.hero_CS.gold -= 150;
            battlegenerator_CS.targetedEnemy.SubstractHP(8);            
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
        this.requiresTarget = true;
        cardCost = 0;
        cardSprite = Resources.Load<Sprite>("Fair_Trade");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 15)
        {
            battlegenerator_CS.hero_CS.gold -= 15;
            //Steal (Hero, Enemy, 1)
            //Bounty (Enemy, 15)
            battlegenerator_CS.targetedEnemy.SubstractHP(8);
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
        cardSprite = Resources.Load<Sprite>("Money_is_Power");
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
        this.requiresTarget = true;
        cardDescription = "Donate 1, Acquire 5.";
        cardCost = 0;
        cardSprite = Resources.Load<Sprite>("Basic_Economy");
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
        cardSprite = Resources.Load<Sprite>("Target_Practice");
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
        this.requiresTarget = true;
        cardCost = 3;
        cardSprite = Resources.Load<Sprite>("Fluid_Exchange");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        if (battlegenerator_CS.hero_CS.gold >= 15)
        {
            battlegenerator_CS.hero_CS.gold -= 15;

            //int x1, x2;
            //x1 = battlegenerator_CS.targetedEnemy.HP;
            battlegenerator_CS.targetedEnemy.SubstractHP(10);
            //x2 = battlegenerator_CS.targetedEnemy.HP;
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
        cardSprite = Resources.Load<Sprite>("Bastion");
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
        this.requiresTarget = true;
        cardCost = 2;
        cardSprite = Resources.Load<Sprite>("One_for_All");
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
        cardSprite = Resources.Load<Sprite>("All_for_One");
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
        this.requiresTarget = true;
        cardCost = 0;
        cardSprite = Resources.Load<Sprite>("Basic_Movements");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(1);
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
        this.requiresTarget = true;
        cardCost = 1;
        cardSprite = Resources.Load<Sprite>("Finishing_Thrust");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //battlegenerator_CS.targetedEnemy.substractHP(2 * battlegenerator_CS.targetedEnemy.NumberOfModifiers);
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
        cardSprite = Resources.Load<Sprite>("Final_Defense");
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
        cardSprite = Resources.Load<Sprite>("Gambling_Heart");
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
        this.requiresTarget = true;
        cardCost = 0;
        cardSprite = Resources.Load<Sprite>("Ace_in_the_Hole");
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.targetedEnemy.SubstractHP(3);        
        //GetRandom Modifier (Enemy, 1)
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}













































