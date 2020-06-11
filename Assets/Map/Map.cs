using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    //public LocationTemplate locations_CS;
    
    public List<LocationTemplate> mainLocationsList = new List<LocationTemplate>();
    public GameObject mark;

    private void Start()
    {
        GenerateLocations();
        mark.SetActive(false);
    }

    public void GenerateLocations()
    {
        Location1 location1 = new Location1();
        Location2 location2 = new Location2();
        Location3 location3 = new Location3();
        Location4 location4 = new Location4();
        Location5 location5 = new Location5();
        Location6 location6 = new Location6();
        Location7 location7 = new Location7();
        Location8 location8 = new Location8();
        Location9 location9 = new Location9();
        Location10 location10 = new Location10();
        Location11 location11 = new Location11();
        
        mainLocationsList.Add(location1);
        mainLocationsList.Add(location2);
        mainLocationsList.Add(location3);
        mainLocationsList.Add(location4);
        mainLocationsList.Add(location5);
        mainLocationsList.Add(location6);
        mainLocationsList.Add(location7);
        mainLocationsList.Add(location8);
        mainLocationsList.Add(location9);
        mainLocationsList.Add(location10);
        mainLocationsList.Add(location11);
    }    
}
