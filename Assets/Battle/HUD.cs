using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text HP;

    public void SETHP(int hp)
    {
        HP.text = hp.ToString();
    }
}
