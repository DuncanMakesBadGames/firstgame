using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float TurnSpeed;
	public float MSpeed;
	public float BackwardsMultiplier;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate (Vector3.forward * TurnSpeed);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Rotate (Vector3.forward * -TurnSpeed);
		}
		if (Input.GetKey (KeyCode.W)) {
			rb.AddRelativeForce(Vector2.up * MSpeed);
		}
		if (Input.GetKey (KeyCode.S)) {
			rb.AddRelativeForce(Vector2.up * -MSpeed * BackwardsMultiplier);
		}
	}
}
