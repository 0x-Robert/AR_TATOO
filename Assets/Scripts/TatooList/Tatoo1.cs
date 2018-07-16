using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tatoo1 : MonoBehaviour {
    float offsetX;
    float offsetY;
    public GameObject[] tatooObj1;
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
            /* tatooObj1[0].SetActive(false);
            tatooObj1[1].SetActive(false);
            tatooObj1[2].SetActive(false);
            tatooObj1[3].SetActive(false);
            tatooObj1[4].SetActive(false);
*/



            for (int i=0; i<tatooObj1.Length; ++i)
            {
                /*tatooObj1[i].SetActive(false);*/
                tatooObj1[i].SetActive(false);
                
            }
        }
    }

    public void OnMouseDown()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0, 0, 15));

    }

}
