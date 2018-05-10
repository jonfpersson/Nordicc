using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class pickUpCollectible : MonoBehaviour
{

    public static RaycastHit hit;
    public Transform cam;
    public Transform[] pages;
    public GameObject[] fires;

    public Text pickup;
    public GameObject wonText;
    public AudioSource sound;
    private int increaseWolfVisionRate = 25;
    int timeWhenWon;
    // Use this for initialization
    void Start()
    {
        //timeWhenWon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(cam.position, cam.forward, out hit))
        {
            if (Vector3.Distance(pages[0].position, transform.position) <= 3)
            {
                // Debug.Log("asd");
                pickup.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.gameObject.name == "fenrirOdinPic")
                    {

                        sound.Play();
                        AiController.lookRadius += increaseWolfVisionRate;

                        Debug.Log("Picked Up");
                        pages[0].gameObject.SetActive(false);
                        fires[0].SetActive(false);
                        spawnWolf.pagesFound++;
                        AiController.runspeed += 5;
                        AiController.walkSpeed += 5;

                    }
                }

            }

            if (Vector3.Distance(pages[1].position, transform.position) <= 3)
            {
                pickup.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.gameObject.name == "fenrirPic")
                    {
                        sound.Play();
                        AiController.lookRadius += increaseWolfVisionRate;

                        Debug.Log("Picked Up");
                        pages[1].gameObject.SetActive(false);
                        fires[1].SetActive(false);
                        spawnWolf.pagesFound++;
                        AiController.runspeed += 5;
                        AiController.walkSpeed += 5;

                    }
                }


            }

            if (Vector3.Distance(pages[2].position, transform.position) <= 3)
            {
                pickup.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.gameObject.name == "beingCapturedWolf")
                    {
                        sound.Play();
                        AiController.lookRadius += increaseWolfVisionRate;

                        Debug.Log("Picked Up");
                        fires[2].SetActive(false);
                        pages[2].gameObject.SetActive(false);
                        spawnWolf.pagesFound++;
                        AiController.runspeed += 5;
                        AiController.walkSpeed += 5;

                    }
                }

            }

            if (Vector3.Distance(pages[3].position, transform.position) <= 3)
            {
                pickup.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.gameObject.name == "angryWolf")
                    {
                        sound.Play();
                        AiController.lookRadius += increaseWolfVisionRate;

                        Debug.Log("Picked Up");
                        pages[3].gameObject.SetActive(false);
                        fires[3].SetActive(false);
                        spawnWolf.pagesFound++;
                        AiController.runspeed += 5;
                        AiController.walkSpeed += 5;

                    }
                }

            }

            if (Vector3.Distance(pages[4].position, transform.position) <= 3)
            {
                pickup.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.gameObject.name == "bigWolf")
                    {
                        sound.Play();
                        AiController.lookRadius += increaseWolfVisionRate;
                        Debug.Log("Picked Up");
                        fires[4].SetActive(false);
                        pages[4].gameObject.SetActive(false);
                        spawnWolf.pagesFound++;
                        AiController.runspeed += 5;
                        AiController.walkSpeed += 5;

                    }
                }

            }

            if (!(Vector3.Distance(pages[4].position, transform.position) <= 3) && !(Vector3.Distance(pages[3].position, transform.position) <= 3)
                && !(Vector3.Distance(pages[2].position, transform.position) <= 3) && !(Vector3.Distance(pages[1].position, transform.position) <= 3)
                && !(Vector3.Distance(pages[0].position, transform.position) <= 3))
                pickup.gameObject.SetActive(false);

        }

        //Detect when game has ended
        if (spawnWolf.pagesFound == 5)
        {
            wonText.SetActive(true);
            StartCoroutine(endGame());
        }

    }

    IEnumerator endGame()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);

    }


}
