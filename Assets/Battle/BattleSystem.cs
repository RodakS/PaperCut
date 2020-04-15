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

    public Transform playerPlace ; // tu podstawiam miejsce w którym mają być
    public Transform enemyPlace ;


    public BattleState state;  // tworze status
    Shield Shielder = new Shield();
    Weapon Weaponer = new Weapon();
    Hero heroUnit;   //kopie bohatera/przeciwnika
    Enemy enemyUnit;
    Card Attack = new Card();
    Deck deck = new Deck();

    public Text enemyHPText ;    // do wyswietlania hp
    public Text heroHPText;
    public Text enemyShieldText;    // do wyswietlania tarczy
    public Text heroShieldText;
    public Text statusText;
    public Text enemyStrength;
    public Text heroEnergy;
    public Text enemyIntent;
    public Text heroStrength;
    public Text Durability;
    public Text cards;
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
        statusText.text = state + " ";

        checkHP();

    }

    

    void checkHP()
    {
        enemyHPText.text = enemyUnit.HP + "/" + enemyUnit.MaxHP;
        heroHPText.text = heroUnit.HP + "/" + heroUnit.MaxHP;
        enemyShieldText.text = "Shield: " + enemyUnit.Shield;
        heroShieldText.text = "Shield: " + heroUnit.Shield;
        heroEnergy.text = "Energy:" + heroUnit.energy + "/" + heroUnit.maxenergy;
        enemyStrength.text = "Strength : " + enemyUnit.AttackUp;
        heroStrength.text = "Strength : " + heroUnit.AttackUp;
        Durability.text = "Durability : "+ Weaponer.CurrDurrability+ "/"+Weaponer.MaxDurability + " Durability : " + Shielder.CurrDurrability + "/" + Shielder.MaxDurability;
        switch (enemyUnit.intent)
        {
            case 1:
                enemyIntent.text = "Attack for " +(int) (enemyUnit.AttackUp + 5);
                break;
            case 2:
                enemyIntent.text = "Defend for 10";
                break;
            case 3:
                enemyIntent.text = "Defend for 6, 2 strength up";
                break;
            case -1:
                enemyIntent.text = "Fuck I'm stunned";
                break;
        }

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
            cards.text = tmp;
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
