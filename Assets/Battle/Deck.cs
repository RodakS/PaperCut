using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using PaperCut;

public class Deck : MonoBehaviour
{
    CardTMP Attack = new CardTMP();
    Card CardUNO;
    List<Action> functions = new List<Action>();

    public void Generate()
    {
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
        functions.Add(Attack.Effect);
    }
    public string  CardDraw(string text)
    {
        Action randomFunc = functions[new System.Random().Next(0, functions.Count)];
        randomFunc();
        functions.Remove(randomFunc);
        text = "Cards: " + functions.Count;
        return text;
    }
}
