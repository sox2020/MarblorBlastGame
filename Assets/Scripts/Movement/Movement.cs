using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

	public float speed;
	public float jump;

	public Transform cam;

	private Rigidbody rb;
	private Collider col;

	private float moveHorizontal;
	private float moveVertical;

	private bool isOnGround;

	//private NetworkInfo network;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		col = GetComponent<Collider> ();
		//network = GetComponentInParent<NetworkInfo> ();
	}

	void FixedUpdate ()
	{
		
		isOnGround = Physics.Raycast (transform.position, -Vector3.up, col.bounds.extents.y + 0.05f);
		if (isOnGround) {
			 moveHorizontal = Input.GetAxis ("Horizontal");
			 moveVertical = Input.GetAxis ("Vertical");
		} else {
			 moveHorizontal = Input.GetAxis ("Horizontal") / 4;
			 moveVertical = Input.GetAxis ("Vertical") / 4;
		}
		Vector3 movement =  new Vector3 (moveHorizontal, 0.0f, moveVertical);

		Quaternion camAngle = Quaternion.AngleAxis (180+ cam.rotation.eulerAngles.y, Vector3.up);


		rb.AddForce(camAngle * (speed * movement));

		if (Input.GetButtonDown ("Jump") && isOnGround) {
			rb.AddForce (new Vector3 (0.0f, jump, 0.0f));
		}
	}

}
