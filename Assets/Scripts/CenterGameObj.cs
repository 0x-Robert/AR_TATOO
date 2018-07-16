using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterGameObj : MonoBehaviour {
    public Slider slider;
    public float value;
    public Image image;
    void Start()
    {
        slider = GetComponent<Slider>();
        image = GetComponent<Image>();
        slider.value  = image.color.a;
        
       
      //  tempColor = UI.Slider.value;

    }
}
