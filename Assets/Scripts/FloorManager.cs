using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FloorManager : MonoBehaviour
{
    public static bool moving = false;
    public TextMeshProUGUI floor1Txt;
    public TextMeshProUGUI floor2Txt;
    public TextMeshProUGUI floor3Txt;
    public TextMeshProUGUI floor4Txt;
    public TextMeshProUGUI floor5Txt;
    public TextMeshProUGUI floor6Txt;
    public TextMeshProUGUI floor7Txt;
    public TextMeshProUGUI floor8Txt;
    public TextMeshProUGUI floor9Txt;
    public TextMeshProUGUI floor10Txt;
    public TextMeshProUGUI movingTxt;
    public GameObject firstFloorSign;
    public GameObject secondFloorSign;
    public GameObject thirdFloorSign;
    public GameObject fourthFloorSign;
    public GameObject fifthFloorSign;
    public GameObject sixthFloorSign;
    public GameObject seventhFloorSign;
    public GameObject eightFloorSign;
    public GameObject nineFloorSign;
    public GameObject tenthFloorSign;
    public static int spaceBarCounter = 0;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spaceBarCounter = 0;
        floor1Txt.enabled = true;
        floor2Txt.enabled = false;
        floor3Txt.enabled = false;
        floor4Txt.enabled = false;
        floor5Txt.enabled = false;
        floor6Txt.enabled = false;
        floor7Txt.enabled = false;
        floor8Txt.enabled = false;
        floor9Txt.enabled = false;
        floor10Txt.enabled = false;
        movingTxt.enabled = false;
        firstFloorSign.SetActive(true);
        secondFloorSign.SetActive(false);
        thirdFloorSign.SetActive(false);
        fourthFloorSign.SetActive(false);
        fifthFloorSign.SetActive(false);
        sixthFloorSign.SetActive(false);
        seventhFloorSign.SetActive(false);
        eightFloorSign.SetActive(false);
        nineFloorSign.SetActive(false);
        tenthFloorSign.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (PushButton.buttonPushedStatic && !moving) {
            //yGoal = transform.position.y + 50;
            moving = true;
        }

        if(moving == true){
            floor1Txt.enabled = false;
            floor2Txt.enabled = false;
            floor3Txt.enabled = false;
            floor4Txt.enabled = false;
            floor5Txt.enabled = false;
            floor6Txt.enabled = false;
            floor7Txt.enabled = false;
            floor8Txt.enabled = false;
            floor9Txt.enabled = false;
            floor10Txt.enabled = false;
            movingTxt.enabled = true;
            firstFloorSign.SetActive(false);
            secondFloorSign.SetActive(false);
            thirdFloorSign.SetActive(false);
            fourthFloorSign.SetActive(false);
            fifthFloorSign.SetActive(false);
            sixthFloorSign.SetActive(false);
            seventhFloorSign.SetActive(false);
            eightFloorSign.SetActive(false);
            nineFloorSign.SetActive(false);
            tenthFloorSign.SetActive(false);
            timer += Time.deltaTime;
        }

        if (timer >= 10f) {
            moving = false;
            PushButton.buttonPushedStatic = false;
            spaceBarCounter++;
            timer = 0f;
        }

        if(moving == false ){
            if(spaceBarCounter == 1){
                floor1Txt.enabled = false;
                floor2Txt.enabled = false;
                floor3Txt.enabled = false;
                floor4Txt.enabled = false;
                floor5Txt.enabled = false;
                floor6Txt.enabled = false;
                floor7Txt.enabled = true;
                floor8Txt.enabled = false;
                floor9Txt.enabled = false;
                floor10Txt.enabled = false;
                movingTxt.enabled = false;
                firstFloorSign.SetActive(false);
                secondFloorSign.SetActive(false);
                thirdFloorSign.SetActive(false);
                fourthFloorSign.SetActive(false);
                fifthFloorSign.SetActive(false);
                sixthFloorSign.SetActive(false);
                seventhFloorSign.SetActive(true);
                eightFloorSign.SetActive(false);
                nineFloorSign.SetActive(false);
                tenthFloorSign.SetActive(false);

            }

            if(spaceBarCounter == 2){
                floor1Txt.enabled = false;
                floor2Txt.enabled = false;
                floor3Txt.enabled = false;
                floor4Txt.enabled = false;
                floor5Txt.enabled = false;
                floor6Txt.enabled = false;
                floor7Txt.enabled = false;
                floor8Txt.enabled = false;
                floor9Txt.enabled = true;
                floor10Txt.enabled = false;
                movingTxt.enabled = false;
                firstFloorSign.SetActive(false);
                secondFloorSign.SetActive(false);
                thirdFloorSign.SetActive(false);
                fourthFloorSign.SetActive(false);
                fifthFloorSign.SetActive(false);
                sixthFloorSign.SetActive(false);
                seventhFloorSign.SetActive(false);
                eightFloorSign.SetActive(false);
                nineFloorSign.SetActive(true);
                tenthFloorSign.SetActive(false);
            }
        }	
    }
}
