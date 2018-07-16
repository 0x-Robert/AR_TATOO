using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourDrag : MonoBehaviour {


    float offsetX;
    float offsetY;
    public GameObject[] Gobj4;
    private bool OnClick;

    void Awake()
    {
        OnClick = false;

    }


    public void BeginDrag4()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag4()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick = true;
        if (OnClick == true)
        {
            Gobj4[0].SetActive(false);
            Gobj4[1].SetActive(false);
            Gobj4[2].SetActive(false);
            Gobj4[3].SetActive(false);
            Gobj4[4].SetActive(false);

        }
    }
}
