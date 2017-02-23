using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixShooter : BaseWeapon {
	public GameObject bulObj;


	// Use this for initialization
	void Start () {
		Damage = 40.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Action ()
	{
		Bullet bullet = Instantiate (bulObj, (transform.position + Vector3.forward * 2), transform.rotation).GetComponent<Bullet>();
		bullet.Damage = Damage;
	}
}
