using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PaperCut;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject heroPrefab; //tu podłączam hero <- trzeba poprawić
    public GameObject enemyPrefab; // przeciwnika
    public GameObject HUDPrefab;

    public Transform playerPlace ; // tu podstawiam miejsce w którym mają być
    public Transform enemyPlace ;
    public Transform HUDPlace;


    public BattleState state;  // tworze status
    Shield Shielder = new Shield();
    Weapon Weaponer = new Weapon();
    Hero heroUnit;   //kopie bohatera/przeciwnika
    Enemy enemyUnit;
    HUD HUDSystem;
    Card Attack = new Card();
    Deck deck = new Deck();

  
    void Start()
    {
        state = BattleState.START;
        battleSetUp();
    }


    void battleSetUp() 
    {
       GameObject playerGameObject = Instantiate(heroPrefab, playerPlace);
        heroUnit=playerGameObject.GetComponent<Hero>();

       GameObject enemyGameObject = Instantiate(enemyPrefab, enemyPlace);
        enemyUnit = enemyGameObject.GetComponent<Enemy>();

        GameObject HUDGameObject = Instantiate(HUDPrefab, HUDPlace);
        HUDSystem = HUDGameObject.GetComponent<HUD>();
        deck.Generate();

        checkHP();
        playerTurn();

    }

    void playerTurn()
    {

        state= BattleState.PLAYERTURN;
        heroUnit.energy = heroUnit.maxenergy;


        if (heroUnit.Regeneration > 0)
        {
            heroUnit.HP += 3;
            if (heroUnit.HP > heroUnit.MaxHP)
            {
                heroUnit.HP = heroUnit.MaxHP;
            }
            heroUnit.Regeneration--;
        }
       

        checkHP();
        

    }

    

    void checkHP()
    {
       
        HUDSystem.UpdateHUD(enemyUnit, heroUnit, Weaponer, Shielder);
        if (enemyUnit.HP <= 0)
        {
            state = BattleState.WON;
            //goto ekran koncowy
            HUDSystem.StatusUpdate(state);

        }

        if (heroUnit.HP <= 0)
        {
            state = BattleState.LOST;
            // goto ekran koncowy
            HUDSystem.StatusUpdate(state);

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
        HUDSystem.StatusUpdate(state);
        enemyUnit.Turn(heroUnit); 

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
           Attack.Effect(heroUnit,enemyUnit,1);
            checkHP();

        }

    }
    public void onDefendCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            Attack.Effect(heroUnit, enemyUnit, 2);
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
             Attack.Effect(heroUnit, enemyUnit, 3);
             checkHP();
            string tmpp="sdsdsd ";
            string tmp = deck.CardDraw(tmpp);
            HUDSystem.DeckUpdate(tmp);
        }

    }

    public void onWeaponClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            Weaponer.Effect(heroUnit, enemyUnit);

            checkHP();
        }

    }
    public void onShieldClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            Shielder.Effect(heroUnit, enemyUnit);

            checkHP();
        }

    }


}
