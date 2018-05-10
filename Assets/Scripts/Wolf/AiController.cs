using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{

    public static float lookRadius = 35f;
    Transform[] targets = new Transform[2];
    NavMeshAgent agent;
    public GameObject lostText;
    public static int objectToFollow;
    public AudioSource wolfBarking;
    bool playAudio = true;
    public static int runspeed = 20;
    public static int walkSpeed = 10;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("checkIfWolfIsStuck", 3, 3.0f);

        agent = gameObject.GetComponent<NavMeshAgent>();
        targets[0] = playerManager.instance.player.transform;
        targets[1] = playerManager.instance.followPoint.transform;
        objectToFollow = 1;
        //0 = player
        //1 = FollowPoint

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(objectToFollow);
        float distance = Vector3.Distance(targets[0].position, transform.position);

        //Detect distance between player and wolf, then play barking sound
        if (distance <= lookRadius)
        {
            //folow player
            agent.speed = 12;
            objectToFollow = 0;
            if (playAudio)
            {
                wolfBarking.Play();
                wolfBarking.loop = true;
                playAudio = false;
            }

        }
        else
        {

            agent.speed = 22;
            objectToFollow = 1;
            wolfBarking.loop = false;
            playAudio = true;

        }

        agent.SetDestination(targets[objectToFollow].position);
        if (distance <= 2)
        {
            Debug.Log("Dead");
            StartCoroutine(endGame());
            lostText.SetActive(true);
        }
        //Debug.Log(agent.speed);
        //checkIfWolfIsStuck();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    IEnumerator endGame()
    {
        yield return new WaitForSeconds(3);
        //Application.Quit();
        Application.LoadLevel(0);
    }

    public void checkIfWolfIsStuck()
    {
        Vector3 currentPosition = transform.position;

        StartCoroutine(checkLastPos(currentPosition));
    }

    IEnumerator checkLastPos(Vector3 lastPos)
    {
        yield return new WaitForSeconds(3);
        //Debug.Log("position: "+transform.position);
        //Debug.Log("lastpos: "+lastPos);

        if (transform.position == lastPos)
        {
            Debug.Log("Is stuck");
            wolfBehavior.isStuck = true;

        }

    }
}
