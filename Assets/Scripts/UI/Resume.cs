using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Resume : MonoBehaviour
{
	public Button Button;
	public GameObject gameObjectCanvas;
	private Canvas canvas;

	void Start()
	{
		Button btn = Button.GetComponent<Button>();
		canvas = gameObjectCanvas.GetComponent<Canvas> ();
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		print("escape");
		canvas.enabled = false;
		Cursor.visible = false;
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.None;
	}
}