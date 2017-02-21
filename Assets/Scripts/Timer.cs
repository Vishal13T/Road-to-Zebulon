using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	private float turnTime;

	// Use this for initialization
	void Start () {
		turnTime = 4.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (turnTime > 0) {
			turnTime = turnTime - Time.deltaTime;
		} else {
			turnTime = 4.0f;
		}
	}

	public float TurnTime {
		get {
			return turnTime;
		}
	}
}
