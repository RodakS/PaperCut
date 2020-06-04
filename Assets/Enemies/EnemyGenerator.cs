using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public BattleGenerator battleGenerator_CS;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;




    public Sprite[] enemySprites;


    public void GenerateCombat()
    {
        System.Random rnd = new System.Random();
        this.SetEnemies(rnd.Next(1, 5));
     //   this.SetEnemies(5);
    }


    public void SetEnemies(int scenario)
    {
        Ectocobra ectocobraPrefab = new Ectocobra();
        switch (scenario)
        {
            case 1:
                enemy1.SetActive(true);
                enemy1.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS3 = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.SetActive(true);
                enemy2.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS2 = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy3.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS);


                break;
            case 2:
                enemy1.SetActive(true);
                enemy1.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS3 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.SetActive(true);
                enemy2.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS2 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy3.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS);

                break;
            case 3:
                enemy3.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS3 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS3);

           
                battleGenerator_CS.enemy_CS2.hp = -10;
                enemy2.SetActive(false);


                
                battleGenerator_CS.enemy_CS.hp = -10;
                enemy1.SetActive(false);

                break;
            case 4:
                enemy3.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[3];
                battleGenerator_CS.enemy_CS3 = new Rzdzor().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.SetActive(true);
                enemy2.GetComponent<Image>().sprite = enemySprites[3];
                battleGenerator_CS.enemy_CS2 = new Rzdzor().copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy1.SetActive(true);
                enemy1.GetComponent<Image>().sprite = enemySprites[3];
                battleGenerator_CS.enemy_CS = new Rzdzor().copyIntoThis(battleGenerator_CS.enemy_CS);

                break;
            case 5:
                enemy3.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[5];
                battleGenerator_CS.enemy_CS3 = new OblivionOrb().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.SetActive(false);
                battleGenerator_CS.enemy_CS2.hp = -10;


                enemy1.SetActive(false);
                battleGenerator_CS.enemy_CS.hp = -10;

                break;
        }









    }
    public void GenereateOrbUnderlings()
    {
        enemy2.SetActive(true);
        enemy2.GetComponent<Image>().sprite = enemySprites[2];
        battleGenerator_CS.enemy_CS2 = new Jello().copyIntoThis(battleGenerator_CS.enemy_CS2);

        enemy1.SetActive(true);
        enemy1.GetComponent<Image>().sprite = enemySprites[2];
        battleGenerator_CS.enemy_CS = new Jello().copyIntoThis(battleGenerator_CS.enemy_CS);


    }

}
