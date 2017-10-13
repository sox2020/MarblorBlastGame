using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuExit : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		print ("exit");
		Application.Quit ();
	}
}