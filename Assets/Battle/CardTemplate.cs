using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardTemplate : MonoBehaviour
{
    public CardStun cardstun;
    public BattleGenerator battlegenerator_CS;
    public Text dfdf;
    public string nazwa = "TeplateName";
    public string description = "TemplateDesciption";
    public int cost = 99;

    public void dodaj(string named, string desc, int coste)
    {
        //name = named;
        //description = desc;
        //cost = coste;
    }

    public void Effect()
    {
        cardstun.Effect(battlegenerator_CS.hero_CS, battlegenerator_CS.enemy_CS);
    }

    private void Start()
    {
        dfdf.text = " "+nazwa;
    }
}
