using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;


    #region IBeginDragHandler implemetation
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;

    //    GetComponent<CanvasGroup>().blocksRaycasts = false;

       // throw new System.NotImplementedException();
    }

    #endregion

    #region IDragHandler implemetation
    public void OnDrag (PointerEventData eventData)
    {
        transform.position = Input.mousePosition;

       // throw new System.NotImplementedException();
    }
    #endregion


     #region IEndDragHandler implemetation

    public void OnEndDrag(PointerEventData eventData)
    {

        itemBeingDragged = null;
      //  GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent!= startParent)
        {
            //현재위치가 처음부모위치와 다를때
            //원래 위치로 돌아가기

            transform.position = startPosition;
        }
        


      //  throw new System.NotImplementedException();
    }
    #endregion


}
