using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnxietySlider : MonoBehaviour
{
    //public float sliderNum = 0f;
    public Slider anxietySlide;
    public float scaler = 0.1f;
    public float maxAnxiety = 0f;
    public Text maxValText;
    

    void Update()
    {
        anxietySlide.value += Input.mouseScrollDelta.y * scaler;
        if (anxietySlide.value > maxAnxiety ) {
            maxAnxiety = anxietySlide.value;
            string temp = "Max Anxiety Level: " + anxietySlide.value.ToString("F");
            maxValText.text = temp;
        }

    }
}
