using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolletMovement : MonoBehaviour {

	public float BulletSpeed;
	public Rigidbody2D rb;
	public float timeLeft;

	// Use this for initialization
	void Start () {
		rb.AddForce (transform.up * BulletSpeed);
		Destroy (gameObject, timeLeft);
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnCollisionEnter (Collision col)
	{
		Destroy(gameObject,0);
	}

}
