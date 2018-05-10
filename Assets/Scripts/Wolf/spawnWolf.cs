using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnWolf : MonoBehaviour {
    public GameObject wolf;
    public Text pagesFoundSign;
    public static int pagesFound;
	// Use this for initialization
	void Start () {
        pagesFound = 0;

    }
	
	// Update is called once per frame
	void Update () {
        pagesFoundSign.text = "Notes found: " + pagesFound.ToString();

       /* if (Input.GetKeyDown("3"))
        {
            
            Instantiate(wolf, new Vector3(255.2417f, 10.36403f, 145.3219f), Quaternion.identity);
            Debug.Log("Wolf spawned");

        }*/

    }
}
