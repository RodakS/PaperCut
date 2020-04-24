using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform enemyPlace;

    public Hero hero_CS;
    public Enemy enemy_CS;
    public HUD hud_CS;
    public Deck deck_CS;

    public Shield shield_CS = new Shield();
    public Weapon weapon_CS = new Weapon();

    public void BattleGenerate()
    {
        GameObject enemyGameObject = Instantiate(enemyPrefab, enemyPlace);
        enemy_CS = enemyGameObject.GetComponent<Enemy>();
    }
}
