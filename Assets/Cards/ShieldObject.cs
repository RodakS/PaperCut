using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldObject : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;

    public int maxDurability = 5;
        public int currDurrability = 5;
        public int armor = 5;
        public int cost = 1;
        public void ExecuteEffect()
        {

            if (battlegenerator_CS.hero_CS.energy >= 1 && this.currDurrability >= 1)
            {
            battlegenerator_CS.hero_CS.shield += this.armor;
                this.currDurrability--;
            battlegenerator_CS.hero_CS.energy--;
            }


        }
        void Start()
        {

        }
    
        void Update()
        {

        }
    }
