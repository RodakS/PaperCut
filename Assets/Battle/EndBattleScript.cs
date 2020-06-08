using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattleScript : MonoBehaviour
{
    private BattleGenerator battlegenerator_CS;
    private BattleSystem battleSystem_CS;
    public Canvas battleCanvas;
    public Canvas cardToChooseCanvas;

    void Start()
    {
        battlegenerator_CS = GetComponent<BattleGenerator>();
        battleSystem_CS = GetComponent<BattleSystem>();
    }

    public void BattleWon()
    {
        if (battlegenerator_CS.weapon_CS.currDurability < battlegenerator_CS.weapon_CS.maxDurability)
        battlegenerator_CS.weapon_CS.currDurability++;
        if (battlegenerator_CS.shield_CS.currDurability < battlegenerator_CS.shield_CS.maxDurability)
            battlegenerator_CS.shield_CS.currDurability++;
        battlegenerator_CS.hero_CS.weak = 0;
        battlegenerator_CS.hero_CS.strength = 0;
        battlegenerator_CS.hero_CS.dexterous = 0;
            battlegenerator_CS.hero_CS.frail = 0;
        battlegenerator_CS.hero_CS.bounty = 0;
        battlegenerator_CS.hero_CS.setOnFire = 0;
        battlegenerator_CS.hero_CS.vulnerable = 0;
        battlegenerator_CS.hero_CS.stun = 0;
        battlegenerator_CS.hero_CS.sleep = 0;
        battlegenerator_CS.hero_CS.regeneration = 0;
        battlegenerator_CS.hero_CS.energy = battlegenerator_CS.hero_CS.maxenergy;
        battleCanvas.enabled = false;
        cardToChooseCanvas.enabled = true;
        battlegenerator_CS.deck_CS.graveyardList.Clear();
        battlegenerator_CS.deck_CS.exhaustList.Clear();
        battlegenerator_CS.hero_CS.shield = 0;
        // dodac czysczenie statusow
        battlegenerator_CS.hud_CS.UpdateHUD();
        battlegenerator_CS.hud_CS.DeckUpdate(battlegenerator_CS.deck_CS.deckList.Count, battlegenerator_CS.deck_CS.graveyardList.Count, battlegenerator_CS.deck_CS.exhaustList.Count);
    }
}
