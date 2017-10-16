using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReached : MonoBehaviour {



	public GameObject particles;

	// Use this for initialization
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			particles.SetActive (true);
			//TODO show a GUI or something
		}
	}
}
