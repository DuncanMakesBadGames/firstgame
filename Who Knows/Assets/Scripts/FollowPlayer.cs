using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform TankButt;
	public Vector3 Offset;

	void Update () {
		transform.position = new Vector3(TankButt.position.x + Offset.x, TankButt.position.y + Offset.y, Offset.z);
	}
}
