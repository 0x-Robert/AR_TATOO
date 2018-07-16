using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tatoo3 : MonoBehaviour {

    float offsetX;
    float offsetY;
    public GameObject[] tatooObj3;
    private bool OnClickTA;

    void Awake()
    {
        OnClickTA = false;

    }

    public void BeginDragTa()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDragTa()
    {

        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);

        OnClickTA = true;
        if (OnClickTA == true)
        {




            for (int i = 0; i < tatooObj3.Length; ++i)
            {
                /*tatooObj1[i].SetActive(false);*/
                tatooObj3[i].SetActive(false);

            }
        }
    }
}
