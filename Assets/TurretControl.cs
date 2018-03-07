﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour {


    public float minBarrelElevation = 15.0f;
    public float maxBarrelElevation = 75.0f;

    public Transform barrelPivotPoint;
    public Transform barrelMouth;

    public GameObject shell;

    public float shellForce = 1000;

    public float turretRotationRate = 90f;
    public float barrelRotationRate = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }



}
