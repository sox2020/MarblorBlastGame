using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

	public GameObject particles;

	[SerializeField]
	int id;
	[SerializeField]
	float power;

	[SerializeField]
	private float rotateSpeed;


	void Update () {
		transform.Rotate (rotateSpeed, 0, 0);
	}

	void OnTriggerEnter( Collider other) {
		if(other.gameObject.tag == "Player") {
			print ("SPEEEEEEEEED");
			if (power != 0) {
				other.gameObject.GetComponent<PlayerPowerup> ().RunPowerup (id, power);
			} else {
				other.gameObject.GetComponent<PlayerPowerup> ().RunPowerup (id);
			}
			//particles.SetActive (true);
			Destroy (gameObject);
		}
	}

}

