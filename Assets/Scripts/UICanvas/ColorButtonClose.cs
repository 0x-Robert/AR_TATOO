using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButtonClose : MonoBehaviour {



    // Activate and deactivate a GameObject.
    // The GUI function implements two buttons.  These buttons
    // toggle the attached GameObject.
    // Note that this script needs to be attached to a
    // GameObject that isn't disabled.


    public GameObject ColorListClose;
    private int count=1;
    bool offclick;
    public GameObject[] gamOBJ;

    

    void Start()
    {
        int count = 1;

    }

    public void ColorListCloseBtn()
    {
        if (offclick = true)
        {
            count++;
            ColorListClose.SetActive(false);
            Debug.Log("첫번째"+count);
            
        }
        if (count%2==0 )
        {
            Debug.Log("두번째"+count);
            ColorListClose.SetActive(true);

            for(int i=0; i<gamOBJ.Length; i++)
            {
                gamOBJ[i].SetActive(true);
            }
            /*  gamOBJ[0].SetActive(true);
            gamOBJ[1].SetActive(true);
            gamOBJ[2].SetActive(true);
            gamOBJ[3].SetActive(true);
            gamOBJ[4].SetActive(true);
            gamOBJ[5].SetActive(true);
*/

        }

    }







}
