using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireExitScript : MonoBehaviour
{
    public Card_ButtonScript card_Button_CS;
    public CampFireScript campfire_CS;
    public Canvas mapCanvas;
    public Canvas campfireCanvas;
 public void CampfireExit()
    {
        if (campfire_CS.isInCampfire==false)
        {
            mapCanvas.enabled = true;
            campfireCanvas.enabled = false;
        }
    }
}
