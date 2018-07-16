using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterButtonClose : MonoBehaviour {


    private int count = 1;
    bool offclick;
    public GameObject[] TatooObj;
    public GameObject ListButton;

    void Start()
    {
        int count = 1;

    }

    public void CloseGUI()
    {

        if (offclick = true)
        {
            count++;
            ListButton.SetActive(false);
            Debug.Log("첫번째" + count);
        }
        if(count%2 == 0)
        {
            ListButton.SetActive(true);
            Debug.Log("두번째" + count);
            for (int i = 0; i < TatooObj.Length; i++)
            {
                TatooObj[i].SetActive(true);
            }
        }
    }



}
