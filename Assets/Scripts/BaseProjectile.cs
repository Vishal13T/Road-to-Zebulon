using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour {
	private float damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	public float Damage {
		get {
			return damage;
		}
		set {
			damage = value;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Entity") {
			((Entity)other.GetComponent<Entity>()).Health = ((Entity)other.GetComponent<Entity>()).Health - damage;
		}
	}
}
