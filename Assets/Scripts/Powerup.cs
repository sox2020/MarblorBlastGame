using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {


	public int id;

	[SerializeField]
	private float rotateSpeed;


	void Update () {
		transform.Rotate (rotateSpeed, 0, 0);
	}
}
