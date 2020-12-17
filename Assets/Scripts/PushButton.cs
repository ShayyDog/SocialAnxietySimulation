using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public GameObject selectedObject;
    public bool buttonPushed = false;
    public static bool buttonPushedStatic = false;
    public static GameObject currentActiveButton;
    public int buttonNum;
    void Update()
    {
        if (gameObject.name == CastingToObject.selectedObject) {
            if(Input.GetMouseButtonDown(0)) {
                if (buttonNum != SituationManager.desiredButton) {
                    SituationManager.correctButtonPressed = false;
                }
                else if (buttonPushed == false) {
                    buttonPushed = true;
                    buttonPushedStatic = true;
                    GetComponent<SelectedHighlight>().enabled = false;
                    currentActiveButton = gameObject;
                }
                else {
                    buttonPushed = false;
                    gameObject.GetComponent<Renderer>().material.color = new Color32(41, 41, 41, 0);
                    GetComponent<SelectedHighlight>().enabled = true;
                }
            }
        }

        if (buttonPushed) {
            gameObject.GetComponent<Renderer>().material.color = new Color32(229, 171, 96, 125);
        }
        if (buttonPushedStatic == false) {
            gameObject.GetComponent<Renderer>().material.color = new Color32(41, 41, 41, 0);
            GetComponent<SelectedHighlight>().enabled = true;
            buttonPushed = false;
        }
    }
}
