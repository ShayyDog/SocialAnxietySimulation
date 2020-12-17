using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
        Animator animator;
        public float waitTime;
        private float timer;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!FloorManager.moving){
            if (Input.GetKey(KeyCode.E)) {
                animator.SetBool("DoorOpening", true);
                timer = waitTime;
            }
            else {
                timer -= Time.deltaTime;
                if (timer <= 0) {
                    animator.SetBool("DoorOpening", false);
                }
            }
        }
    }
}
