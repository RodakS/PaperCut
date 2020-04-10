using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   public  int MaxDurability = 5;
   public int CurrDurrability = 5;
    public int Damage = 5;
    public int Cost = 1;
    public void Effect(Hero HeroUnit, Enemy EnemyUnit)
    {
       
                if (HeroUnit.energy >= 1 && this.CurrDurrability >=1)
                {
                    EnemyUnit.substractHP(this.Damage);
                    this.CurrDurrability--;
                    HeroUnit.energy--;
                }
             

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
public class Shield : MonoBehaviour
{
    public int MaxDurability = 5;
    public int CurrDurrability = 5;
    public int Armor = 5;
    public int Cost = 1;
    public void Effect(Hero HeroUnit, Enemy EnemyUnit)
    {

        if (HeroUnit.energy >= 1 && this.CurrDurrability >= 1)
        {
            HeroUnit.Shield += this.Armor;
            this.CurrDurrability--;
            HeroUnit.energy--;
        }


    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
