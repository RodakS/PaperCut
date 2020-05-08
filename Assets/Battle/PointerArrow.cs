using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArrow : MonoBehaviour
{
    public GameObject arrow;
    public void HideThis()
    {
        arrow.SetActive(false);
    }
    public void PointTo1()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(340, 240, 0);
    }
    public void PointTo2()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(580, 240, 0);
    }
    public void PointTo3()
    {
        arrow.SetActive(true);
        arrow.GetComponent<RectTransform>().localPosition = new Vector3(800, 240, 0);
    }
}
