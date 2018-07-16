using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterButton : MonoBehaviour {

	// Activate and deactivate a GameObject.
// The GUI function implements two buttons.  These buttons
// toggle the attached GameObject.
// Note that this script needs to be attached to a
// GameObject that isn't disabled.


    public GameObject GO;

    bool OnClick;

  public  void OpenGUI()
    {
        if (OnClick =true)
        {
           
            GO.SetActive(true);
        }

    }
    





}
