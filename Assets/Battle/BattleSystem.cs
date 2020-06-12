using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    private BattleGenerator battlegenerator_CS;
    public BattleState state;

    public Canvas BattleCanvas;
    public Canvas MapCanvas;

    void Start()
    {
        battlegenerator_CS = GetComponent<BattleGenerator>(); //podłączam battlegenerator.cs 
        MapCanvas.enabled = true;
        BattleCanvas.enabled = false;
        BattleSetUp();
    }

    public  void BattleSetUp() 
    {
        state = BattleState.START;
        battlegenerator_CS.deck_CS.Generate();  // tworze deck
        battlegenerator_CS.enemyGenerator_CS.GenerateCombat();
        CheckHP();
        PlayerTurn();
    }

    void PlayerTurn()
    {

        battlegenerator_CS.deck_CS.UpdateCards();
        
        state = BattleState.PLAYERTURN;

        battlegenerator_CS.hero_CS.ResetEnergy(); 

        CheckHP();
    }
    

    

    void CheckHP()
    {
        if (battlegenerator_CS.enemy_CS.IsDead())
        {
            
            battlegenerator_CS.enemyPrefab.SetActive(false);
            battlegenerator_CS.hero_CS.gold += battlegenerator_CS.enemy_CS.bounty;
            battlegenerator_CS.enemy_CS.bounty = 0;
        }
        if (battlegenerator_CS.enemy_CS2.IsDead())
        {
            battlegenerator_CS.enemyPrefab2.SetActive(false);
            battlegenerator_CS.hero_CS.gold += battlegenerator_CS.enemy_CS.bounty;
            battlegenerator_CS.enemy_CS.bounty = 0;
        }
        if (battlegenerator_CS.enemy_CS3.IsDead())
        {
            battlegenerator_CS.enemyPrefab3.SetActive(false);
            battlegenerator_CS.hero_CS.gold += battlegenerator_CS.enemy_CS.bounty;
            battlegenerator_CS.enemy_CS.bounty = 0;
        }

        battlegenerator_CS.hud_CS.UpdateHUD();

        if (battlegenerator_CS.mapsystem_CS.yourLocation == 11 && battlegenerator_CS.enemy_CS.IsDead() && battlegenerator_CS.enemy_CS2.IsDead() && battlegenerator_CS.enemy_CS3.IsDead())
        {
            state = BattleState.WON;
            //goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

            battlegenerator_CS.endBattleScript_CS.GameWon();

        }


        if (battlegenerator_CS.enemy_CS.IsDead() && battlegenerator_CS.enemy_CS2.IsDead() && battlegenerator_CS.enemy_CS3.IsDead())      
        {
            state = BattleState.WON;
            //goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

            battlegenerator_CS.endBattleScript_CS.BattleWon();

        }

        if (battlegenerator_CS.hero_CS.IsDead())  
        {
            state = BattleState.LOST;
            // goto ekran koncowy
            battlegenerator_CS.hud_CS.StatusUpdate(state);

        }
        battlegenerator_CS.hud_CS.StatusUpdate(state);
        battlegenerator_CS.deck_CS.UpdateCards();


    }

    public void OnEndTurnClick()
    {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }

        battlegenerator_CS.deck_CS.VoidDamage();
        EnemyTurn();
 
    }

    void EnemyTurn()
    {
        state = BattleState.ENEMYTURN;
        if (!(battlegenerator_CS.enemy_CS.IsDead()))
        {
            battlegenerator_CS.enemy_CS.ResetShield();
           battlegenerator_CS.enemy_CS.ExecuteTurn();
            CheckHP();
            
           // System.Threading.Thread.Sleep(500);
        }

        if (!(battlegenerator_CS.enemy_CS2.IsDead()))
        {
            battlegenerator_CS.enemy_CS2.ResetShield();
            battlegenerator_CS.enemy_CS2.ExecuteTurn();
            CheckHP();
           // System.Threading.Thread.Sleep(500);
        }

        if (!(battlegenerator_CS.enemy_CS3.IsDead()))
        {
            battlegenerator_CS.enemy_CS.ResetShield();
            battlegenerator_CS.enemy_CS3.ExecuteTurn();
            CheckHP();
        }
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
