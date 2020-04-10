using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    int MaxDurability = 5;
    int CurrDurrability = 5;
    int Damage = 5;
    int Cost = 1;
    public void Effect(Hero HeroUnit, Enemy EnemyUnit)
    {
       
                if (HeroUnit.energy >= 1 && this.CurrDurrability >=1)
                {
                    EnemyUnit.substractHP(this.Damage);
                    this.CurrDurrability--;
                    HeroUnit.energy--;
                }
             

    }

}
public class Shield : MonoBehaviour
{
    int MaxDurability = 5;
    int CurrDurrability = 5;
    int Armor = 5;
    int Cost = 1;
    public void Effect(Hero HeroUnit, Enemy EnemyUnit)
    {

        if (HeroUnit.energy >= 1 && this.CurrDurrability >= 1)
        {
            HeroUnit.Shield += this.Armor;
            this.CurrDurrability--;
            HeroUnit.energy--;
        }


    }

}
