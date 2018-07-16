using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveDrag : MonoBehaviour {

    float offsetX;
    float offsetY;
    public GameObject[] Gobj5;
    private bool OnClick;

    void Awake()
    {
        OnClick = false;

    }


    public void BeginDrag5()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag5()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick = true;
        if (OnClick == true)
        {
            Gobj5[0].SetActive(false);
            Gobj5[1].SetActive(false);
            Gobj5[2].SetActive(false);
            Gobj5[3].SetActive(false);
            Gobj5[4].SetActive(false);

        }
    }
}
