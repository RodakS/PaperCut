using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PaperCut;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject heroPrefab; //tu podłączam hero <- trzeba poprawić
    public GameObject enemyPrefab ; // przeciwnika

    public Transform playerPlace ; // tu podstawiam miejsce w którym mają być
    public Transform enemyPlace ;


    public BattleState state;  // tworze status

    Hero heroUnit = new Hero();      //kopie bohatera/przeciwnika
    Enemy enemyUnit = new Enemy();
    CardAttack Attack = new CardAttack();
    CardBlock Block = new CardBlock();

    //Hero heroUnit;     //kopie bohatera/przeciwnika
    //Enemy enemyUnit;
    //CardAttack Attack;
    //CardBlock Block;

    public Text enemyHPText ;    // do wyswietlania hp
    public Text heroHPText;
    public Text enemyShieldText;    // do wyswietlania tarczy
    public Text heroShieldText;
    public Text statusText;

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

        checkHP();
        playerTurn();
    }

    void playerTurn()
    {

        state= BattleState.PLAYERTURN;
        heroUnit.energy = heroUnit.maxenergy;
        statusText.text = state + " ";

    }

    

    void checkHP()
    {
        enemyHPText.text = enemyUnit.HP + "/" + enemyUnit.MaxHP;
        heroHPText.text = heroUnit.HP + "/" + heroUnit.MaxHP;
        enemyShieldText.text = "Shield: " + enemyUnit.Shield;
        heroShieldText.text = "Shield: " + heroUnit.Shield;

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

    void enemyTurn()
    {
        state = BattleState.ENEMYTURN;
        statusText.text = state + " ";
        enemyUnit.Turn(heroUnit);  // ew coś co ma zrobić przeciwnik

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
            //enemyUnit.HP = enemyUnit.HP - 5;

            checkHP();
        }
        
    }
    public void onDefendCardClick()
    {
        if (state == BattleState.PLAYERTURN)
        {
            Attack.Effect(heroUnit, enemyUnit, 2);
            //enemyUnit.HP = enemyUnit.HP - 5;

            checkHP();
        }

    }


}
