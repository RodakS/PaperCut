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
                RogueBatPrefab3.intentText = battleGenerator_CS.enemy_CS3.intentText;
                RogueBatPrefab3.enemyHP = battleGenerator_CS.enemy_CS3.enemyHP;
                RogueBatPrefab3.enemyShield = battleGenerator_CS.enemy_CS3.enemyShield;
                RogueBatPrefab3.enemyStrength = battleGenerator_CS.enemy_CS3.enemyStrength;
                battleGenerator_CS.enemy_CS3 = RogueBatPrefab3;

                enemy2.GetComponent<Image>().sprite = enemySprites[0];
                RogueBat RogueBatPrefab2 = new RogueBat();
                RogueBatPrefab2.intentText = battleGenerator_CS.enemy_CS2.intentText;
                RogueBatPrefab2.enemyHP = battleGenerator_CS.enemy_CS2.enemyHP;
                RogueBatPrefab2.enemyShield = battleGenerator_CS.enemy_CS2.enemyShield;
                RogueBatPrefab2.enemyStrength = battleGenerator_CS.enemy_CS2.enemyStrength;
                battleGenerator_CS.enemy_CS2 = RogueBatPrefab2;

                enemy1.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab = new Ectocobra();
                ectocobraPrefab.intentText = battleGenerator_CS.enemy_CS.intentText;
                ectocobraPrefab.enemyHP = battleGenerator_CS.enemy_CS.enemyHP;
                ectocobraPrefab.enemyShield = battleGenerator_CS.enemy_CS.enemyShield;
                ectocobraPrefab.enemyStrength = battleGenerator_CS.enemy_CS.enemyStrength;
                battleGenerator_CS.enemy_CS = ectocobraPrefab;


                break;
            case 2:
                enemy3.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab3 = new Ectocobra();
                ectocobraPrefab3.intentText = battleGenerator_CS.enemy_CS3.intentText;
                ectocobraPrefab3.enemyHP = battleGenerator_CS.enemy_CS3.enemyHP;
                ectocobraPrefab3.enemyShield = battleGenerator_CS.enemy_CS3.enemyShield;
                ectocobraPrefab3.enemyStrength = battleGenerator_CS.enemy_CS3.enemyStrength;
                battleGenerator_CS.enemy_CS3 = ectocobraPrefab3;

                enemy2.GetComponent<Image>().sprite = enemySprites[1];
                Ectocobra ectocobraPrefab2 = new Ectocobra();
                ectocobraPrefab2.intentText = battleGenerator_CS.enemy_CS2.intentText;
                ectocobraPrefab2.enemyHP = battleGenerator_CS.enemy_CS2.enemyHP;
                ectocobraPrefab2.enemyShield = battleGenerator_CS.enemy_CS2.enemyShield;
                ectocobraPrefab2.enemyStrength = battleGenerator_CS.enemy_CS2.enemyStrength;
                battleGenerator_CS.enemy_CS2 = ectocobraPrefab2;


                enemy1.GetComponent<Image>().sprite = enemySprites[0];
                RogueBat RogueBatPrefab = new RogueBat();
                RogueBatPrefab.intentText = battleGenerator_CS.enemy_CS.intentText;
                RogueBatPrefab.enemyHP = battleGenerator_CS.enemy_CS.enemyHP;
                RogueBatPrefab.enemyShield = battleGenerator_CS.enemy_CS.enemyShield;
                RogueBatPrefab.enemyStrength = battleGenerator_CS.enemy_CS.enemyStrength;
                battleGenerator_CS.enemy_CS = RogueBatPrefab;

                break;
        }
      


    }



  


    

}
