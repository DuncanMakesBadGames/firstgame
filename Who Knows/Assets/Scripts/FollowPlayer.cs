using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform TankButt;
	public Vector3 Offset;


	void Update () {
		transform.position = new Vector3(TankButt.position.x + Offset.x, TankButt.position.y + Offset.y, Offset.z);

		float ScrollWheel = Input.GetAxis ("Mouse ScrollWheel");

		if(ScrollWheel < 0){
			UnityEngine.Camera.main.orthographicSize += 0.1f * UnityEngine.Camera.main.orthographicSize;
		}
		if(ScrollWheel > 0){
			UnityEngine.Camera.main.orthographicSize -= 0.1f * UnityEngine.Camera.main.orthographicSize;
		}

		if (UnityEngine.Camera.main.orthographicSize < 0.5f) {
			UnityEngine.Camera.main.orthographicSize = 0.5f;
		}
		if (Input.GetMouseButtonDown (2)) {
			UnityEngine.Camera.main.orthographicSize = 8.0f;
		}

	}
}
