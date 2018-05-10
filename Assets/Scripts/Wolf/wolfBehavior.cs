using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfBehavior : MonoBehaviour
{

    Animator wolfAnimator;
    public GameObject wolfFollowPoint;
    private Vector3 followPointCoordinate;
    private float xFollowPoint;
    private float zFollowPoint;
    private float oldxFollowPoint;
    private float oldzFollowPoint;
    private int transportRate;
    private int lookRadius = 60;
    public static bool isStuck = false;
    // Use this for initialization
    void Start()
    {
        transportRate = 200;
        wolfAnimator = gameObject.GetComponent<Animator>();
        wolfAnimator.Play("run");
        AiController.objectToFollow = 1;

        //InvokeRepeating("LetWolfWalkingFreely", 5, 5.0f);

        followPointCoordinate = wolfFollowPoint.transform.position;
        xFollowPoint = followPointCoordinate.x;
        zFollowPoint = followPointCoordinate.z;
    }

    // Update is called once per frame
    void Update()
    {
        followPointCoordinate = wolfFollowPoint.transform.position;

        if (Input.GetKeyDown("1"))
        {
            wolfAnimator.Play("run");
        }

        if (Input.GetKeyDown("2"))
        {
            wolfAnimator.Play("idle");
        }

        if (Input.GetKeyDown("3"))
        {
            wolfAnimator.Play("walk");
        }

        if (Input.GetKeyDown("7"))
        {
            AiController.objectToFollow = 0;
        }
        LetWolfWalkingFreely();
    }

    public void LetWolfWalkingFreely()
    {

        //Debug.Log("Distance: " + Vector3.Distance(followPointCoordinate, transform.position));
        if (Vector3.Distance(followPointCoordinate, transform.position) <= lookRadius || isStuck == true)
        {
            isStuck = false;
            //Debug.Log("IsClose");
            oldxFollowPoint = xFollowPoint;
            oldzFollowPoint = zFollowPoint;

            xFollowPoint += Random.Range(-transportRate, transportRate);
            zFollowPoint += Random.Range(-transportRate, transportRate);
            //Debug.Log("zFollowPoint: " + zFollowPoint + " xFollowPoint: " + xFollowPoint);

            if (xFollowPoint < 500 && zFollowPoint > 0 && zFollowPoint < 500 && xFollowPoint > 0)
            {
                wolfFollowPoint.transform.position = new Vector3(xFollowPoint, wolfFollowPoint.transform.position.y, zFollowPoint);
            }
            else
            {
                xFollowPoint = oldxFollowPoint;
                zFollowPoint = oldzFollowPoint;

            }

        }

    }


}
