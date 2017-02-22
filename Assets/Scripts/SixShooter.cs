using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixShooter : BaseWeapon {
	public GameObject bulObj;
	private Bullet bullet;


	// Use this for initialization
	void Start () {
		Damage = 40.0f;
		bullet = bulObj.GetComponent<Bullet> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Action ()
	{
		bullet = Instantiate (bulObj, (transform.position + Vector3.back * 2), transform.rotation).GetComponent<Bullet>();
		bullet.Damage = Damage;
		Rigidbody rb = bullet.GetComponent<Rigidbody> ();
		rb.velocity = transform.TransformDirection(new Vector3 (-1000f, 0, 0));
	}
}
