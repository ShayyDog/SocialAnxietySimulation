using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedHighlight : MonoBehaviour
{

    public GameObject selectedObject;
    public int redCol;
    public int greenCol;
    public int blueCol;
    public bool lookingAtObject = false;
    public bool lit = true;
    public bool started = false;

    void Update()
    {
        if (lookingAtObject == true) {
            selectedObject.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 125);
        }
    }

    void OnMouseOver() {
        selectedObject = GameObject.Find(CastingToObject.selectedObject);
        lookingAtObject = true;
        if (started == false) {
            started = true;
            StartCoroutine(FlashObject());
        }
    }

    void OnMouseExit() {
        started = false;
        lookingAtObject = false;
        StopCoroutine(FlashObject());
        selectedObject.GetComponent<Renderer>().material.color = new Color32(41, 41, 41, 0);
        selectedObject = null;
        redCol = 0;
        greenCol = 0;
        blueCol = 0;
    }

    IEnumerator FlashObject() {
        while(lookingAtObject == true) {
            yield return new WaitForSeconds(0.05f);
            if (lit == true) {
                if(blueCol <= 30) {
                    lit = false;
                }
                else {
                    blueCol -= 25;
                    greenCol -= 1;
                }
            }

            if(lit == false) {
                if (blueCol >= 250) {
                    lit = true;
                }
                else {
                    blueCol += 25;
                    greenCol += 1;
                }
            }
        }
    }
}