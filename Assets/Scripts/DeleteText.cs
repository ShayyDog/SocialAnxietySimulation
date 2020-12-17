using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteText : MonoBehaviour
{
    public Text startText;
    private bool pressed = false;
    //startText.enabled = true;

    // Update is called once per frame
    void Update()
    {
        if (FloorManager.moving) {
            pressed = false;
        }

        if (!FloorManager.moving && !pressed) {
            startText.enabled = true;
            if(Input.GetKey(KeyCode.E)) {
                startText.enabled = false;
                pressed = true;
            }
        }
    }
}
