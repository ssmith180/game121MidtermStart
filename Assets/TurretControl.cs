using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour {


    public float minBarrelElevation = 15.0f;
    public float maxBarrelElevation = 75.0f;

    public Transform barrelPivotPoint;
    public Transform barrelMouth;

    public GameObject shell;

    public float launchForce = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // FIRE
            GameObject newShell = GameObject.Instantiate(shell, barrelMouth.transform.position, barrelMouth.transform.rotation);
            newShell.GetComponent<Rigidbody>().AddForce(newShell.transform.forward * launchForce);
        }

	}
}
