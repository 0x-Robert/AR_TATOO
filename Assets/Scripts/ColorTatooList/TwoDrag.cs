using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDrag : MonoBehaviour {

    float offsetX;
    float offsetY;
    public GameObject[] Gobj2;
    private bool OnClick;

    void Awake()
    {
        OnClick = false;

    }


    public void BeginDrag2()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag2()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick = true;
        if (OnClick == true)
        {
            Gobj2[0].SetActive(false);
            Gobj2[1].SetActive(false);
            Gobj2[2].SetActive(false);
            Gobj2[3].SetActive(false);
            Gobj2[4].SetActive(false);

        }
    }
}
