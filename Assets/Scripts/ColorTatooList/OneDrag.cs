using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneDrag : MonoBehaviour {
    float offsetX;
    float offsetY;
    public GameObject[] Gobj;
    private bool OnClick2;

    void Awake()
    {
        OnClick2 = false;

    }

    public void BeginDrag()
    {

        offsetX = transform.position.x -
            Input.mousePosition.x;
        offsetX = transform.position.y -
           Input.mousePosition.y;

    }

    public void OnDrag()
    {
        
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);
        OnClick2 = true;
        if (OnClick2 == true)
        {
            Gobj[0].SetActive(false);
            Gobj[1].SetActive(false);
            Gobj[2].SetActive(false);
            Gobj[3].SetActive(false);
            Gobj[4].SetActive(false);

        }
    }


    public void OnMouseDown()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0, 0, 15));

    }
}
