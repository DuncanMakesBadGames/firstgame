using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float TurnSpeed;
	public float MSpeed;

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
			transform.Translate (0, MSpeed, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -MSpeed, 0);
		}
	}
}
