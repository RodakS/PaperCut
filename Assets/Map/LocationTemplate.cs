using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public abstract class LocationTemplate : MonoBehaviour
{
    public string locationName = "Location";
    public string locationDescription = "Description";
    public int id;
    public int encounter;
    public string encounterDescription = "Description";    
    public Sprite locationSprite;
    public int posX;
    public int posY;
    public abstract void Replace();
    public abstract void Effect(BattleGenerator tmp);
}

public class Location1 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 1;
        encounterDescription = "Fight against a weak enemy.";
        id = 1;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(3);
        battlegenerator_CS.hud_CS.UpdateHUD();
        
        //pojedynczy
    }
}

public class Location2 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 1;
        encounterDescription = "Fight against a weak enemy.";
        id = 2;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(1);
        battlegenerator_CS.hud_CS.UpdateHUD();
        //wielu
    }
}

public class Location3 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 2;
        encounterDescription = "Fight against multiple weak enemies.";
        id = 3;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(3);
        //pojedynczy
    }
}

public class Location4 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 2;
        encounterDescription = "Fight against multiple weak enemies.";
        id = 4;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {

        //ognisko
    }
}

public class Location5 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 3;
        encounterDescription = "Treasure chest.";
        id = 5;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //skrzynka
    }
}

public class Location6 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 1;
        encounterDescription = "Fight against a weak enemy.";
        id = 6;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //ognisko
    }
}

public class Location7 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 2;
        encounterDescription = "Fight against multiple weak enemies.";
        id = 7;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(2);
        battlegenerator_CS.hud_CS.UpdateHUD();
        //wielu
    }
}

public class Location8 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 2;
        encounterDescription = "Fight against multiple weak enemies.";
        id = 8;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(2);
        battlegenerator_CS.hud_CS.UpdateHUD();
        //wielu
    }
}

public class Location9 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 1;
        encounterDescription = "Fight against a weak enemy.";
        id = 9;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(4);
        battlegenerator_CS.hud_CS.UpdateHUD();
        //wielu
    }
}

public class Location10 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 3;
        encounterDescription = "Treasure chest.";
        id = 10;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        //skrzynka
    }
}

public class Location11 : LocationTemplate
{
    public override void Replace()
    {
        locationName = "";
        locationDescription = "";
        encounter = 4;
        encounterDescription = "fight against a strong enemy.";
        id = 11;
    }
    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemyGenerator_CS.SetEnemies(5);
        battlegenerator_CS.hud_CS.UpdateHUD();
        //boss

    }
}