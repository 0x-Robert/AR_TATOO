using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorButton : MonoBehaviour {

    public GameObject colorList;
    bool isColor;



	public void ColorButtonOn()
    {
        if(isColor = true)
        {
            colorList.SetActive(true);

        }
        

    }
}
