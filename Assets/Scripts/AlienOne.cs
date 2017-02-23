using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienOne : Entity {
	private float maxHealth = 40.0f;
	private float maxCycleTime = 1.0f;
	private float cycleTime;
	private Vector3 movement = Vector3.right;
	// Use this for initialization
	void Start () {
		cycleTime = 0f; 
		Health = maxHealth;
		Speed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		cycleTime -= Time.deltaTime;
		if (Health <= 0) {
			Destroy (gameObject);
		}
		if (cycleTime <= 0 && (transform.position.x < -7 || transform.position.x > 7)) {
			movement *= -1f;
			cycleTime = maxCycleTime;
		}

		transform.Translate (movement * Speed * Time.deltaTime);
	}
}
