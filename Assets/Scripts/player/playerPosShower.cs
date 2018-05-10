using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPosShower : MonoBehaviour {
    public float lookRadius = 20f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }


}
