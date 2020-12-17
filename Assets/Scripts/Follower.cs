using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator1;
    public PathCreator pathCreator2;
    private PathCreator activePath;
    public float speed = 5;
    float distanceTravelled;
    public EndOfPathInstruction end;
    bool start = false;
    bool finished1 = false;
    Animator animator;
    public int startCount;
    public int exitCount;

    void Start () {
        animator = GetComponent<Animator>();
        activePath = pathCreator1;
    }

    void Update() {
        if (!FloorManager.moving && (startCount == FloorManager.spaceBarCounter || exitCount == FloorManager.spaceBarCounter)) {

            if (Input.GetKeyDown(KeyCode.E) && start == false) {
                start = true;
                animator.SetBool("EOP", false);
            }

            if (start) {
                distanceTravelled += speed * Time.deltaTime;
                transform.position = activePath.path.GetPointAtDistance(distanceTravelled, end);
                transform.rotation = activePath.path.GetRotationAtDistance(distanceTravelled, end);
            }

            if (transform.position == activePath.path.GetPoint(activePath.path.NumPoints - 1))
            {
                animator.SetBool("EOP", true);
                if (pathCreator2 != null && !finished1) {
                    start = false;
                    activePath = pathCreator2;
            
                    distanceTravelled = 0;
                }
                finished1 = true;
            }
        }
    }
    
}
