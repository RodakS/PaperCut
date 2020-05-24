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
        this.SetEnemies(rnd.Next(1,3));
    }


    public void SetEnemies(int scenario)
    {

        switch (scenario)
        {
            case 1:
                enemy3.GetComponent<Image>().sprite = enemySprites[0];
                RogueBat RogueBatPrefab3 = new RogueBat();
                battleGenerator_CS.enemy_CS3 = RogueBatPrefab3.copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.GetComponent<Image>().sprite = enemySprites[0];
                RogueBat RogueBatPrefab2 = new RogueBat();
                battleGenerator_CS.enemy_CS2 = RogueBatPrefab2.copyIntoThis(battleGenerator_CS.enemy_CS2);

                enemy1.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab = new Ectocobra();
                battleGenerator_CS.enemy_CS = ectocobraPrefab.copyIntoThis(battleGenerator_CS.enemy_CS);


                break;
            case 2:
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab3 = new Ectocobra();
                battleGenerator_CS.enemy_CS3 = ectocobraPrefab3.copyIntoThis(battleGenerator_CS.enemy_CS3);

                enemy2.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab2 = new Ectocobra();
                battleGenerator_CS.enemy_CS2 = ectocobraPrefab2.copyIntoThis(battleGenerator_CS.enemy_CS3);


                enemy1.GetComponent<Image>().sprite = enemySprites[0];
                RogueBat RogueBatPrefab = new RogueBat();
                battleGenerator_CS.enemy_CS = RogueBatPrefab.copyIntoThis(battleGenerator_CS.enemy_CS3);

                break;
        }
      


    }



  


    

}
