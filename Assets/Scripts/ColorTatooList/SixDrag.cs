using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixDrag : MonoBehaviour {

    float offsetX;
    float offsetY;
    public GameObject[] Gobj6;
    private bool OnClick;

    void Awake()
    {
        OnClick = false;

    }

    

    public void BeginDrag6()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag6()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick = true;
        if (OnClick == true)
        {
            Gobj6[0].SetActive(false);
            Gobj6[1].SetActive(false);
            Gobj6[2].SetActive(false);
            Gobj6[3].SetActive(false);
            Gobj6[4].SetActive(false);

        }
    }
}
