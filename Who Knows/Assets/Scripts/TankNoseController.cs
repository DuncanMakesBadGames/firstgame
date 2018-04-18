using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankNoseController : MonoBehaviour {

	public float aimspeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var pos = Camera.main.WorldToScreenPoint(transform.position);
		var dir = Input.mousePosition - pos;
		var angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg)-90;
		Quaternion letsago = Quaternion.AngleAxis(angle,Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, letsago, Time.deltaTime * aimspeed); 

	}
}
