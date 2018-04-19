using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankNoseController : MonoBehaviour {

	public float aimspeed = 0.1f;
	public GameObject Boollet;
	public float ShootCooldown;
	private float ShootCooldownTimer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Turning

		var pos = Camera.main.WorldToScreenPoint(transform.position);
		var dir = Input.mousePosition - pos;
		var angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg)-90;
		Quaternion letsago = Quaternion.AngleAxis(angle,Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, letsago, Time.deltaTime * aimspeed); 

		//Bullet Creation

		ShootCooldownTimer -= Time.deltaTime;

		if (Input.GetButton("Fire1") && ShootCooldownTimer < 0) {
			GameObject instance = GameObject.Instantiate (Boollet) as GameObject;
			ShootCooldownTimer = ShootCooldown;

			instance.transform.rotation = transform.rotation;
			instance.transform.position = transform.position;
			instance.transform.Translate (0.0f,1.16f,0.0f);

		}
	}
}
