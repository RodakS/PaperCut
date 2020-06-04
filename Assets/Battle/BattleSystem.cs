using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    private BattleGenerator battlegenerator_CS;
    public BattleState state;

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
        battlegenerator_CS.enemyGenerator_CS.GenerateCombat();
        CheckHP();
        PlayerTurn();
    }

    void PlayerTurn()
    {
        state= BattleState.PLAYERTURN;

        battlegenerator_CS.hero_CS.ResetEnergy(); 

        CheckHP();
    }
    

    

    void CheckHP()
    {
        if (battlegenerator_CS.enemy_CS.IsDead())
        {
            
            battlegenerator_CS.enemyPrefab.SetActive(false);
        }
        if (battlegenerator_CS.enemy_CS2.IsDead())
        {
            battlegenerator_CS.enemyPrefab2.SetActive(false);
        }
        if (battlegenerator_CS.enemy_CS3.IsDead())
        {
            battlegenerator_CS.enemyPrefab3.SetActive(false);
        }

        battlegenerator_CS.hud_CS.UpdateHUD();
        if (battlegenerator_CS.enemy_CS.IsDead() && battlegenerator_CS.enemy_CS2.IsDead() && battlegenerator_CS.enemy_CS3.IsDead())      
        {
            state = BattleState.WON;
            //goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

        }

        if (battlegenerator_CS.hero_CS.IsDead())  
        {
            state = BattleState.LOST;
            // goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

        }
        battlegenerator_CS.hud_CS.StatusUpdate(state);



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
        if (!(battlegenerator_CS.enemy_CS.IsDead()))
            battlegenerator_CS.enemy_CS.ExecuteTurn();
        if (!(battlegenerator_CS.enemy_CS2.IsDead()))
            battlegenerator_CS.enemy_CS2.ExecuteTurn();
        if (!(battlegenerator_CS.enemy_CS3.IsDead()))
            battlegenerator_CS.enemy_CS3.ExecuteTurn();
        CheckHP();
        if (state == BattleState.ENEMYTURN)
        {
            PlayerTurn();
        }
        battlegenerator_CS.hud_CS.StatusUpdate(state);
        CheckHP();
        

    }

    public void OnWeaponClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.weapon_CS.ExecuteEffect();

            CheckHP();
        }

    }
    public void OnShieldClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            battlegenerator_CS.shield_CS.ExecuteEffect();

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
