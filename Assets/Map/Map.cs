using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public BattleGenerator battlegenerator_CS;
    public LocationTemplate locations_CS;

    public List<LocationTemplate> locationsList = new List<LocationTemplate>();
    public void GeneterateLocations()
    {
        locationsList.Add(new Location1());
        locationsList.Add(new Location2());
        locationsList.Add(new Location3());
        locationsList.Add(new Location4());
        locationsList.Add(new Location5());
        locationsList.Add(new Location6());
        locationsList.Add(new Location7());
        locationsList.Add(new Location8());
        locationsList.Add(new Location9());
        locationsList.Add(new Location10());
        locationsList.Add(new Location11());
    }    
}
