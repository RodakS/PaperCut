using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Deck : MonoBehaviour
{
    public GameObject Card;
   
    KartaOrginalna t;

    public Text[] texts;
    public List<KartaOrginalna>Klasy = new List<KartaOrginalna>();
    public void Generate(BattleGenerator battlegenerator_CS)
    {
        t = new KartaPierwsza();
        //functions.Add(Card);
       // GameObject karta = functions[new System.Random().Next(0, functions.Count)];
        //cardTemplate_CS.CardReplace(karta);

        Klasy.Add(t);
        Klasy.Add(t);
        t = Klasy[new System.Random().Next(0, Klasy.Count)];
        t.Effect(battlegenerator_CS);

        //      functions.Add(cardFlip);
        //      CardOneObject = functions[new System.Random().Next(0, functions.Count)];
        //      Debug.Log("siema " + CardOneObject);
        // tmp.Effect() = cardsss.AttackEffect();
        //   functions.Add(Attack.Effect);

    }
    public void CardDraw(int cardNumer)//(CardObject)
    {
        texts[3 * (cardNumer-1) + 0].text = t.Name;
        texts[3 * (cardNumer-1) + 1].text = t.Description;
        texts[3 * (cardNumer-1) + 2].text = t.Cost.ToString();
        // GameObject playerGameObject = Instantiate(karta, playerPlace);
        // heroUnit = playerGameObject.GetComponent<Hero>();



        //Action randomFunc = functions[new System.Random().Next(0, functions.Count)];
        //randomFunc();
        //functions.Remove(randomFunc);
        //text = "Cards: " + functions.Count;
        //return text;

        //Action cardtemplateObject = functions[new System.Random().Next(0, functions.Count)];
        // cardtemplateObject
        // functions.Remove(cardtemplateObject);
        // text = "Cards: " + functions.Count;

    }

}
