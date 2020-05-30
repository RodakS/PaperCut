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
        this.SetEnemies(rnd.Next(1,4));
    }


    public void SetEnemies(int scenario)
    {
        Ectocobra ectocobraPrefab = new Ectocobra();
        switch (scenario)
        {
            case 1:
                enemy1.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS3 = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy1.SetActive(true);
                enemy2.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS2 = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy1.SetActive(true);
                enemy1.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS);


                break;
            case 2:
                enemy1.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS3 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy1.SetActive(true);
                enemy2.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS2 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy1.SetActive(true);
                enemy1.GetComponent<Image>().sprite = enemySprites[0];
                battleGenerator_CS.enemy_CS = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS);

                break;
            case 3:
                enemy1.SetActive(true);
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                battleGenerator_CS.enemy_CS3 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.SetActive(false);
                battleGenerator_CS.enemy_CS2.isDed = true;
                battleGenerator_CS.enemy_CS2 = new Ectocobra().copyIntoThis(battleGenerator_CS.enemy_CS2);


                enemy1.SetActive(false);
                battleGenerator_CS.enemy_CS.isDed = true;
                battleGenerator_CS.enemy_CS = new RogueBat().copyIntoThis(battleGenerator_CS.enemy_CS);

                break;
        }
      


    }



  


    

}
