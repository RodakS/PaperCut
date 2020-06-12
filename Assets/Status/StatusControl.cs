using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusControl : MonoBehaviour
{
    public BattleGenerator battleGenerator_CS;
    public Text strength;
    public Text weak;
    public Text frail;
    public Text dexterous;
    public Text regenerate;
    public Text setonfire;
    public Text vulnerable;
    public Text bounty;
    public Text stun;
    public Text sleep;

    public GameObject contentOne;
    public GameObject StatusListObject;
    public GameObject contentTwo;
    public GameObject StatusListEnemyTwoObject;
    public GameObject contentThree;
    public GameObject StatusListEnemyThreeObject;
    private GameObject tmpStatusGameObjectTMP;
    public void UpdateWithHero()
    {
        this.strength.text = battleGenerator_CS.hero_CS.strength.ToString();
        this.weak.text = battleGenerator_CS.hero_CS.weak.ToString();
        this.frail.text = battleGenerator_CS.hero_CS.frail.ToString();
        this.dexterous.text = battleGenerator_CS.hero_CS.dexterous.ToString();
        this.regenerate.text = battleGenerator_CS.hero_CS.regeneration.ToString();
        this.setonfire.text = battleGenerator_CS.hero_CS.setOnFire.ToString();
        this.vulnerable.text = battleGenerator_CS.hero_CS.vulnerable.ToString();
        this.bounty.text = battleGenerator_CS.hero_CS.bounty.ToString();
        this.stun.text = battleGenerator_CS.hero_CS.stun.ToString();
        this.sleep.text = battleGenerator_CS.hero_CS.sleep.ToString();

    }

    public void ResetEnemyStatus()
    {
        foreach (Transform child in contentOne.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in contentTwo.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in contentThree.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
    public void UpdateEnemiesStatus()
    {

            if (battleGenerator_CS.enemy_CS.strength > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.strength.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("strenght"); 
            }            
            if (battleGenerator_CS.enemy_CS.weak > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.weak.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("weak"); 
            }            
            if (battleGenerator_CS.enemy_CS.frail > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.frail.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("frail"); 
            }            
            if (battleGenerator_CS.enemy_CS.dexterous > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.dexterous.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("dexterous"); 
            }            
            //if (battleGenerator_CS.enemy_CS.regenerate > 0)
            //{
            //    tmpStatusGameObject = Instantiate(StatusListEnemyOneObject, contentOne.transform);
            //    tmpStatusGameObject.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.regenerate.ToString();
            //    tmpStatusGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("regeneration"); 
            //}            
            if (battleGenerator_CS.enemy_CS.setOnFire > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.setOnFire.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("set_on_fire"); 
            }
            if (battleGenerator_CS.enemy_CS.vulnerable > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.vulnerable.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("vulnerable");
            }
            if (battleGenerator_CS.enemy_CS.bounty > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.bounty.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("bounty"); 
            }            
            if (battleGenerator_CS.enemy_CS.stun > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.stun.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("stun"); 
            }            
            if (battleGenerator_CS.enemy_CS.sleep > 0)
            {
                tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentOne.transform);
                tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS.sleep.ToString();
                tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("sleep"); 
            }






        if (battleGenerator_CS.enemy_CS2.strength > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.strength.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("strenght");
        }
        if (battleGenerator_CS.enemy_CS2.weak > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.weak.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("weak");
        }
        if (battleGenerator_CS.enemy_CS2.frail > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.frail.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("frail");
        }
        if (battleGenerator_CS.enemy_CS2.dexterous > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.dexterous.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("dexterous");
        }
        //if (battleGenerator_CS.enemy_CS2.regenerate > 0)
        //{
        //    tmpStatusGameObject = Instantiate(StatusListEnemyOneObject, contentTwo.transform);
        //    tmpStatusGameObject.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.regenerate.ToString();
        //    tmpStatusGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("regeneration"); 
        //}            
        if (battleGenerator_CS.enemy_CS2.setOnFire > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.setOnFire.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("set_on_fire");
        }
        if (battleGenerator_CS.enemy_CS2.vulnerable > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.vulnerable.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("vulnerable");
        }
        if (battleGenerator_CS.enemy_CS2.bounty > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.bounty.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("bounty");
        }
        if (battleGenerator_CS.enemy_CS2.stun > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.stun.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("stun");
        }
        if (battleGenerator_CS.enemy_CS2.sleep > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentTwo.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS2.sleep.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("sleep");
        }



        if (battleGenerator_CS.enemy_CS3.strength > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.strength.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("strenght");
        }
        if (battleGenerator_CS.enemy_CS3.weak > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.weak.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("weak");
        }
        if (battleGenerator_CS.enemy_CS3.frail > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.frail.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("frail");
        }
        if (battleGenerator_CS.enemy_CS3.dexterous > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.dexterous.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("dexterous");
        }
        //if (battleGenerator_CS.enemy_CS3.regenerate > 0)
        //{
        //    tmpStatusGameObject = Instantiate(StatusListEnemyOneObject, contentThree.transform);
        //    tmpStatusGameObject.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.regenerate.ToString();
        //    tmpStatusGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("regeneration"); 
        //}            
        if (battleGenerator_CS.enemy_CS3.setOnFire > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.setOnFire.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("set_on_fire");
        }
        if (battleGenerator_CS.enemy_CS3.vulnerable > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.vulnerable.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("vulnerable");
        }
        if (battleGenerator_CS.enemy_CS3.bounty > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.bounty.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("bounty");
        }
        if (battleGenerator_CS.enemy_CS3.stun > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.stun.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("stun");
        }
        if (battleGenerator_CS.enemy_CS3.sleep > 0)
        {
            tmpStatusGameObjectTMP = Instantiate(StatusListObject, contentThree.transform);
            tmpStatusGameObjectTMP.transform.GetChild(0).GetComponent<Text>().text = battleGenerator_CS.enemy_CS3.sleep.ToString();
            tmpStatusGameObjectTMP.GetComponent<Image>().sprite = Resources.Load<Sprite>("sleep");
        }
    }
}
