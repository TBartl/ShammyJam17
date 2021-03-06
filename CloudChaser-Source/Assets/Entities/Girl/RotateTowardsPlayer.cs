﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour {
    Transform player;

    void Awake() {
        GameObject g = GameObject.FindGameObjectWithTag("Player");
        if (g)
            player = g.transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (player) {
            this.transform.rotation =  Quaternion.LookRotation(this.transform.position - player.transform.position, Vector3.up);
            this.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
		
	}
}
