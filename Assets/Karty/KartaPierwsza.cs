using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartaPierwsza : CardTemplate
{
    public override void Replace()
    {
        cardName = " Pierwsza";
        cardDescription = " costam";
        cardCost = 2;
    }

    public override void Effect(BattleGenerator battlegenerator_CS)
    {
            battlegenerator_CS.enemy_CS.SubstractHP(10);
            battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}

public class KartaDruga : CardTemplate
{
    public override void Replace()
    {
        cardName = "Druga";
        cardDescription = " itede";
        cardCost = 1;
    }

    public override void Effect(BattleGenerator battlegenerator_CS)
    {
        battlegenerator_CS.enemy_CS.SubstractHP(5);
        battlegenerator_CS.hero_CS.energy -= cardCost;
    }
}


