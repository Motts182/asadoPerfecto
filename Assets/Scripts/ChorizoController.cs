﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChorizoController : MonoBehaviour {
    public string carneNombre = "Chorizo";
    public Sprite carneSprite;
    
    public void SetParrilla()
    {

        var btns = GameObject.FindGameObjectsWithTag("btni");

        CarneALaParrilla(btns);
    }

    public void CarneALaParrilla(GameObject[] btns)
    {
        foreach (GameObject btn in btns)
        {
            if (btn.GetComponent<ParrillaSlotController>().empty)
            {
                btn.GetComponent<Image>().sprite = carneSprite;
                btn.GetComponent<ParrillaSlotController>().empty = false;
                btn.GetComponent<ParrillaSlotController>().carneNombre = carneNombre;
                btn.GetComponent<ParrillaSlotController>().tiempoDeCoccion = 12;
                break;
            }
        }
    }
}
