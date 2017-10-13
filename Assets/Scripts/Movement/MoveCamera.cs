using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	
	public GameObject player;

	private Vector3 offset;
	public float minCam, maxCam;

	float mouseX, mouseY;

	public float mouseSpeed;

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		mouseX = Input.GetAxis ("MouseX");
		mouseY = Input.GetAxis ("MouseY");
		transform.localEulerAngles += /*(new Vector3 (-transform.localEulerAngles.x,
			transform.localEulerAngles.y, 0.0f)) +*/ (new Vector3(mouseY*mouseSpeed,mouseX*mouseSpeed,0.0f));

		/*if (transform.localEulerAngles.x < minCam) {
			transform.localEulerAngles = new Vector3(
				minCam,
				transform.localEulerAngles.y,
				transform.localEulerAngles.z
			);
		} else if (transform.localEulerAngles.x > maxCam) {

			transform.localEulerAngles = new Vector3(
				maxCam,
				transform.localEulerAngles.y,
				transform.localEulerAngles.z
			);

	

		}*/



		transform.position = player.transform.position + offset;
	}
}