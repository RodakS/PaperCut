using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSystem : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public Map map_CS;
    public int yourLocation = 0;

    public List<LocationTemplate> locationsList;

    public void Generate()
    {
        map_CS = GetComponent<Map>();
        locationsList = new List<LocationTemplate>(map_CS.mainLocationsList);
    }

    public Canvas BattleCanvas;
    public Canvas MapCanvas;
    public Canvas CardChooseCanvas;


    public void OnLocationOneClick()
    {
        if (yourLocation == 0)
        {
            yourLocation = 1;
            battlegenerator_CS.map_CS.mainLocationsList[0].Effect(battlegenerator_CS);            
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationTwoClick()
    {
        if (yourLocation == 1)
        {
            yourLocation = 2;
            battlegenerator_CS.map_CS.mainLocationsList[1].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationThreeClick()
    {
        if (yourLocation == 1)
        {
            yourLocation = 3;
            battlegenerator_CS.map_CS.mainLocationsList[2].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationFourClick()
    {
        if (yourLocation == 2)
        {
            yourLocation = 4;
            battlegenerator_CS.map_CS.mainLocationsList[3].Effect(battlegenerator_CS);
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationFiveClick()
    {
        if (yourLocation == 3)
        {
            yourLocation = 5;
            battlegenerator_CS.map_CS.mainLocationsList[4].Effect(battlegenerator_CS);
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationSixClick()
    {
        if (yourLocation == 3)
        {
            yourLocation = 6;
            battlegenerator_CS.map_CS.mainLocationsList[5].Effect(battlegenerator_CS);
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationSevenClick()
    {
        if (yourLocation == 4)
        {
            yourLocation = 7;
            battlegenerator_CS.map_CS.mainLocationsList[6].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationEightClick()
    {
        if (yourLocation == 5)
        {
            yourLocation = 8;
            battlegenerator_CS.map_CS.mainLocationsList[7].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationNineClick()
    {
        if (yourLocation == 6)
        {
            yourLocation = 9;
            battlegenerator_CS.map_CS.mainLocationsList[8].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationTenClick()
    {
        if (yourLocation == 9)
        {
            yourLocation = 10;
            battlegenerator_CS.map_CS.mainLocationsList[9].Effect(battlegenerator_CS);
            CardChooseCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }
    public void OnLocationElevenClick()
    {
        if (yourLocation == 7 | yourLocation == 8 | yourLocation == 10)
        {
            yourLocation = 11;
            battlegenerator_CS.map_CS.mainLocationsList[10].Effect(battlegenerator_CS);
            BattleCanvas.enabled = true;
            MapCanvas.enabled = false;
        }
    }

    void Start()
    {
        
    }
        
    void Update()
    {
        
    }
}
