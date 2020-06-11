using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSystem : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public BattleSystem battleSystem_CS;
    public Map map_CS;
    public int yourLocation = 0;
    public GameObject mark;
    Vector3 Vector;

    public List<LocationTemplate> locationsList;

    public void Generate()
    {
        map_CS = GetComponent<Map>();
        locationsList = new List<LocationTemplate>(map_CS.mainLocationsList);        
    }

    public Canvas BattleCanvas;
    public Canvas MapCanvas;
    public Canvas CardChooseCanvas;
    public Canvas CampfireCanvas;


    public void OnLocationOneClick()
    {
        if (yourLocation == 0)
        {
            yourLocation = 1;
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[0].Effect(battlegenerator_CS);
            mark.SetActive(true);
        }
    }
    public void OnLocationTwoClick()
    {
        if (yourLocation == 1)
        {
            yourLocation = 2;            
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[1].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(406, 340, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationThreeClick()
    {
        if (yourLocation == 1)
        {
            yourLocation = 3;            
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[2].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(406, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationFourClick()
    {
        if (yourLocation == 1)
        {
            yourLocation = 4;
            CampfireCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[3].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(406, -337, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationFiveClick()
    {
        if (yourLocation == 2)
        {
            yourLocation = 5;
            CampfireCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[4].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(347, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationSixClick()
    {
        if (yourLocation == 3)
        {
            yourLocation = 6;
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[5].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(347, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationSevenClick()
    {
        if (yourLocation == 4)
        {
            yourLocation = 7;
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[6].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(347, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationEightClick()
    {
        if (yourLocation == 5)
        {
            yourLocation = 8;
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[7].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(350, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationNineClick()
    {
        if (yourLocation == 6)
        {
            yourLocation = 9;
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[8].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(350, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationTenClick()
    {
        if (yourLocation == 7)
        {
            yourLocation = 10;
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[9].Effect(battlegenerator_CS);
            mark.SetActive(true);
            Vector = new Vector3(350, 0, 0);
            mark.GetComponent<RectTransform>().localPosition += Vector;
        }
    }
    public void OnLocationElevenClick()
    {
        if (yourLocation == 8 | yourLocation == 9 | yourLocation == 10)
        {
            yourLocation = 11;
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
            battleSystem_CS.BattleSetUp();
            battlegenerator_CS.map_CS.mainLocationsList[10].Effect(battlegenerator_CS);
            mark.SetActive(false);
        }
    }

}
