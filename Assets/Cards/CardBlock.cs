using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaperCut
{
    public class CardBlock : MonoBehaviour
    {
        public int Id = 2;
        public string Name = "Block";
        public string Description = "Gain 10 block.";
        public int Cost = 1;
        public void Effect()
        {
           // Hero.Shield += 10;
        }


        //przy użyciu zasób/energia/stanima bohatera spadłaby o 1
        //Hero.Resource -= CardBlock.Cost;

        //przy użyciu tarcza bohatera wzrosłaby o 10
        //CardBlock.Effect();
        
        //albo

        //public int Effect()
        //{
        //    int Block = 10;
        //    return Block;
        //}

        //Hero.Shield += CardBlock.Effect();


        void Start()
        {

        }

        void Update()
        {

        }
    }
}