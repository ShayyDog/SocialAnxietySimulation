using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAroundScript : MonoBehaviour
{

    public float rotMult = 4f;

    float yaw = 0f;
    float pitch = 0f;

    public float maxY = -65;
    public float minY = 50;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = !Cursor.visible;
        }
        else {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            yaw += rotMult * Input.GetAxis("Mouse X");
            pitch -= rotMult * Input.GetAxis("Mouse Y");
            pitch = Mathf.Clamp(pitch, maxY, minY);

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
