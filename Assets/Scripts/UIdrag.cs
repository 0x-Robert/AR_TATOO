using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIdrag : MonoBehaviour {

    float offsetX;
    float offsetY;
    float rotSpeed = 20;

    float offsetZ;


   

    public void BeginDrag()
    {
        offsetX = transform.position.x -
          Input.mousePosition.x;
        offsetY = transform.position.y -
           Input.mousePosition.y;
        offsetZ = transform.position.z -
          Input.mousePosition.z;



        //    float rotZ = Input.GetAxis("Mouse Z") * rotSpeed * Mathf.Deg2Rad;

        //  transform.RotateAround(Vector3.up, -offsetZ);

        // transform.RotateAround(Vector3.right, -offsetX);

        // transform.RotateAround(Vector3.up, -offsetX);

        //      transform.RotateAround(Vector3.right, -offsetZ);
        //      transform.RotateAround(Vector3.left, -offsetZ);


    }

    public void OnDrag()
    {
        transform.position =
            new Vector3(offsetX + Input.mousePosition.x,
            offsetY + Input.mousePosition.y);


        
        //   transform.RotateAround(Vector3.up, -offsetY);

        //    transform.RotateAround(Vector3.right, -offsetZ);
    }

    public void OnMouseDown()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.Rotate(new Vector3(0, 0, 15));

    }

}
