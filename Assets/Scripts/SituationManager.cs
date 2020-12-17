using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SituationManager : MonoBehaviour
{
    public static bool correctButtonPressed = true;
    public static int desiredButton;
    public AudioSource audioSource;
    public AudioClip voiceClip;

    void Update()
    {
        if (FloorManager.spaceBarCounter == 0) {
            desiredButton = 7;
        }

        if (FloorManager.spaceBarCounter == 1) {
            desiredButton = 9;
        }

        if (correctButtonPressed == false) {
            audioSource.PlayOneShot(voiceClip, 0.5f);
            correctButtonPressed = true;
        }
    }
}
