using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour {

    public GameObject tatooObj;

    bool obj;

    public void openOBJ()
    {
        if (obj=true)
        {

            tatooObj.SetActive(true);
        }
       
    }
}
