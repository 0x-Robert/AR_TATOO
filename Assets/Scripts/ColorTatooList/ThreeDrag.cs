using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDrag : MonoBehaviour {



    float offsetX;
    float offsetY;
    public GameObject[] Gobj3;
    private bool OnClick;

    void Awake()
    {
        OnClick = false;

    }


    public void BeginDrag3()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag3()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick = true;
        if (OnClick == true)
        {
            Gobj3[0].SetActive(false);
            Gobj3[1].SetActive(false);
            Gobj3[2].SetActive(false);
            Gobj3[3].SetActive(false);
            Gobj3[4].SetActive(false);

        }
    }
}
