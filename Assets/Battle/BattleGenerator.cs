using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform enemyPlace;

    public Hero hero_CS;
    public Enemy enemy_CS;
    public Enemy enemy_CS2;
    public Enemy enemy_CS3;
    public HUD hud_CS;
    public Deck deck_CS;

    public Shield shield_CS;
    public Weapon weapon_CS;
    public Enemy targetedEnemy;


    public void BattleGenerate()
    {
        //GameObject enemyGameObject = Instantiate(enemyPrefab, enemyPlace);
      //  enemy_CS = enemyGameObject.GetComponent<Enemy>();

    }
}
