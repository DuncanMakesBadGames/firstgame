using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public GameObject Boom;

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Boollet")) {

			Destroy (gameObject);
			Destroy (other.gameObject);

			GameObject instance = GameObject.Instantiate (Boom) as GameObject;
			instance.transform.position = transform.position;
		}
	}
}
