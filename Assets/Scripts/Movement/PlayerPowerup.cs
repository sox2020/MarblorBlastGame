using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerup : MonoBehaviour {


	private Rigidbody rb;


	void Start() {
		rb = gameObject.GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Powerup") {
			int id = col.gameObject.GetComponent<Powerup> ().id;
			print (id);
			switch (id) {
			case 0:
				print ("SPPEEEEEEDDDD!!!!");
				rb.velocity = rb.velocity * 10;
				break;
			default:
				break;
			}
			Destroy(col.gameObject);
		} 
	}
}
