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

	void OnTriggerEnter(Collider other) {
		Entity target = other.GetComponent<Entity> ();
		if (target != null) {
			target.Health = target.Health - damage;
		}
			
	}

	public float Damage {
		get {
			return damage;
		}
		set {
			damage = value;
		}
	}
}
