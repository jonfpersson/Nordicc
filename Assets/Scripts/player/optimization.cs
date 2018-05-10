using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optimization : MonoBehaviour {

    public GameObject waterObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Vector3.Distance(waterObj.transform.position, transform.position) > 120)
        {
            waterObj.SetActive(false);
        } else
            waterObj.SetActive(true);
            */
        //Debug.Log(Vector3.Distance(waterObj.transform.position, transform.position));
    }
}
