using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerup : MonoBehaviour {


	private Rigidbody rb;
	private Movement mv;


	void Start() {
		rb = gameObject.GetComponent<Rigidbody> ();
		mv = gameObject.GetComponent<Movement> ();
	}

	public void RunPowerup(int id, float power = 5) {
		//Destroy (other.gameObject);
		//print ("collided with " + other.gameObject.name);
		//if (other.gameObject.tag == "Powerup") {
			//int id = other.gameObject.GetComponent<Powerup> ().id;
			print (id);
			switch (id) {
			case 0:
				print ("SPPEEEEEEDDDD!!!!");
				rb.velocity = rb.velocity * power;
				break;
		case 1:
				mv.jump *= power;
				break;
			default:
				break;
			}
			//Destroy(other.gameObject);
		//} 
	}
	/*
	void OnTriggerEnter(Collider col) {
		print ("collided with speed");
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
	*/
}
