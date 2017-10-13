using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkInfo : NetworkBehaviour {

	[HideInInspector]
	public bool bLocalPlayer;

	void Start () {
		bLocalPlayer = isLocalPlayer;
	}

}
