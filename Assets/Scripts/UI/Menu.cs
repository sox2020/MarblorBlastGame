using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	private Canvas canvas;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		canvas = gameObject.GetComponent<Canvas> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape) && !canvas.enabled)
		{
			canvas.enabled = true;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.Confined;
			Time.timeScale = 0;
	
		} else if (Input.GetKeyDown (KeyCode.Escape) && canvas.enabled)
		{
			canvas.enabled = false;
			Cursor.visible = false;
			Time.timeScale = 1;
			Cursor.lockState = CursorLockMode.None;
		}
	}
}