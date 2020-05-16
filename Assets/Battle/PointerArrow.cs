using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArrow : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public GameObject arrow;
    public void HideThis()
    {
        arrow.SetActive(false);
        battlegenerator_CS.targetedEnemy = null;
    }
    public void PointTo1()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(340, 240, 0);
        battlegenerator_CS.targetedEnemy = battlegenerator_CS.enemy_CS;
    }
    public void PointTo2()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(580, 240, 0);
        battlegenerator_CS.targetedEnemy = battlegenerator_CS.enemy_CS2;
    }
    public void PointTo3()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(800, 240, 0);
        battlegenerator_CS.targetedEnemy = battlegenerator_CS.enemy_CS3;
    }
}
