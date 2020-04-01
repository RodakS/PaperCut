using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PaperCut;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject heroPrefab;  //tu podłączam hero
    public GameObject enemyPrefab; // przeciwnika

    public Transform playerPlace; // tu podstawiam miejsce w którym mają być
    public Transform enemyPlace;


    public BattleState state;  // tworze status

    Hero heroUnit;      //kopie bohatera/przeciwnika
    Enemy enemyUnit;
    CardAttack Attack;

    public Text enemyHPText;    // do wyswietlania hp
    public Text heroHPText;
    public Text statusText;
    public Button buttom;
    public Button buttom2;
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

        enemyHPText.text = enemyUnit.HP + "/" + enemyUnit.MaxHP ;
        heroHPText.text = heroUnit.HP + "/" + heroUnit.MaxHP;

        playerTurn();
    }

    void playerTurn()
    {
        state= BattleState.PLAYERTURN;
        statusText.text = state + " ";

    }

    void enemyTurn()
    {
        state = BattleState.ENEMYTURN;
        statusText.text = state + " ";
        enemyUnit.Turn();  // ew coś co ma zrobić przeciwnik
        checkHP();

      //  playerTurn();
    }

    void checkHP()
    {
        if (enemyUnit.HP<=0)
        {
            state = BattleState.WON;
            statusText.text = state + " ";
            //goto ekran koncowy
        }

        if (heroUnit.HP <= 0)
        {
            state = BattleState.LOST;
            statusText.text = state + " ";
            // goto ekran koncowy
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

    public void onCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
           // Attack.Effect(enemyUnit);
            //enemyUnit.HP = enemyUnit.HP - 5;
            enemyHPText.text = enemyUnit.HP + "/" + enemyUnit.MaxHP;

            checkHP();
        }
    }

}
