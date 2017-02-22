using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : BaseProjectile {
	private float time;
	// Use this for initialization
	void Start () {
		time = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time <= 0) {
			Destroy (gameObject);
		}
		transform.Translate (Vector3.forward * Time.deltaTime * 1000f);
	}
}
