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
        battlegenerator_CS.battleGenerate();                    //uruchamiam battlegenerator.cs 
        state = BattleState.START;
        battleSetUp();
    }


    void battleSetUp() 
    {

        battlegenerator_CS.deck_CS.Generate(battlegenerator_CS);  // tworze deck
        battlegenerator_CS.deck_CS.CardDraw(1);
        battlegenerator_CS.deck_CS.CardDraw(2);
        battlegenerator_CS.deck_CS.CardDraw(3);
        checkHP();
        playerTurn();

    }

    void playerTurn()
    {

        state= BattleState.PLAYERTURN;

       // battlegenerator_CS.hero_CS.energy = battlegenerator_CS.hero_CS.maxenergy; // to ma robic bohater a nie battlesystem -->

        checkHP();
    }

    

    void checkHP()
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

    public void onEndTurnClick()
    {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }
        enemyTurn();
    }

    void enemyTurn()
    {
        state = BattleState.ENEMYTURN;

        battlegenerator_CS.enemy_CS.Turn(battlegenerator_CS.hero_CS);
        battlegenerator_CS.hud_CS.StatusUpdate(state);

        checkHP();
        if(state == BattleState.ENEMYTURN)
        { 
             playerTurn();
        }
    }

    public void onAttackCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            Attack.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS, 1);
            checkHP();
            // CardDraw(cardOnePlace);
        }
    }
    public void onDefendCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
           Attack.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS, 2);
            checkHP();
            // draw a card()
            // card effect()
            // card UI
        }
    }
    public void onMiscCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
             Attack.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS, 3);
             checkHP();
        }

    }

    public void onWeaponClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.weapon_CS.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS);

            checkHP();
        }

    }
    public void onShieldClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.shield_CS.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS);

            checkHP();
        }

    }

    public void onCardClickOne() 
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.deck_CS.CardDraw(1);
           // battlegenerator_CS.cardObjectOne.GetComponent<CardTemplate>().Effect();
            checkHP();
            // CardDraw(cardOnePlace);  // dobierz karte
        }
    }

    public void onCardClickTwo()
    {
        if (state == BattleState.PLAYERTURN)
        {
           // battlegenerator_CS.cardObjectTwo.GetComponent<CardTemplate>().Effect();
            checkHP();
            // CardDraw(cardOnePlace);  // dobierz karte
        }
    }

    public void onCardClickThree()
    {
        if (state == BattleState.PLAYERTURN)
        {
           // battlegenerator_CS.cardObjectThree.GetComponent<CardTemplate>().Effect();
            checkHP();
            // CardDraw(cardOnePlace);  // dobierz karte
        }
    }
}
