using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KartaOrginalna : MonoBehaviour
{
   // public BattleGenerator battlegenerator_CS;
    private void Start()
    {
        //battlegenerator_CS = GameObject.FindGameObjectWithTag("GameController").GetComponent<BattleGenerator>();
    }
    public string Name = "PAtak";
    public string Description = "Łubudubu";
    public int Cost = 12;
    public abstract void Effect(BattleGenerator tmp);

}
