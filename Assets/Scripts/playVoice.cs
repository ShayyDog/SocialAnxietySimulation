using System.Collections;
using System.Collections.Generic;
using CrazyMinnow.SALSA;
using UnityEngine;

public class playVoice : MonoBehaviour
{
    public Salsa3D salsa;

    bool playedAlready = false;
    public int entranceStep;

    void Update()
    {
        if (FloorManager.spaceBarCounter == entranceStep) {
            if (Input.GetKey(KeyCode.E)) {
                if (!playedAlready) {
                    salsa.Play();
                    playedAlready = true;
                }
            }
        }
    }
}
