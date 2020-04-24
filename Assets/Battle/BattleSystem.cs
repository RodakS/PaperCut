using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    private BattleGenerator battlegenerator_CS;
    public BattleState state;
    Card Attack = new Card();

    void Start()
    {
        battlegenerator_CS = GetComponent<BattleGenerator>(); //podłączam battlegenerator.cs 
        battlegenerator_CS.BattleGenerate();                   //uruchamiam battlegenerate.cs 
        state = BattleState.START;
        BattleSetUp();
    }

    void BattleSetUp() 
    {
        battlegenerator_CS.deck_CS.Generate();  // tworze deck
        CheckHP();
        PlayerTurn();
    }

    void PlayerTurn()
    {
        state= BattleState.PLAYERTURN;

        battlegenerator_CS.hero_CS.energy = battlegenerator_CS.hero_CS.maxenergy; // to ma robic bohater a nie battlesystem -->

        CheckHP();
    }

    

    void CheckHP()
    {
       
        battlegenerator_CS.hud_CS.UpdateHUD();
        if (battlegenerator_CS.enemy_CS.HP <= 0)       // to ma sprawdzać przeciwnik
        {
            state = BattleState.WON;
            //goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

        }

        if (battlegenerator_CS.hero_CS.HP <= 0)  // to ma sprawdzać bohater
        {
            state = BattleState.LOST;
            // goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

        }

    }

    public void OnEndTurnClick()
    {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }
        EnemyTurn();
    }

    void EnemyTurn()
    {
        state = BattleState.ENEMYTURN;

        battlegenerator_CS.enemy_CS.Turn(battlegenerator_CS.hero_CS);
        battlegenerator_CS.hud_CS.StatusUpdate(state);

        CheckHP();
        if(state == BattleState.ENEMYTURN)
        { 
             PlayerTurn();
        }
    }

    public void OnWeaponClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.weapon_CS.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS);

            CheckHP();
        }

    }
    public void OnShieldClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.shield_CS.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS);

            CheckHP();
        }

    }

    public void OnCardClickOne() 
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.deck_CS.CardPlay(battlegenerator_CS,1);
            CheckHP();
        }
    }

    public void OnCardClickTwo()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.deck_CS.CardPlay(battlegenerator_CS,2);
            CheckHP();
        }
    }

    public void OnCardClickThree()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.deck_CS.CardPlay(battlegenerator_CS,3);
            CheckHP();
        }
    }
}
