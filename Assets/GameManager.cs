using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recordOn = true;

	//private ReplaySystem replaySystem;
	
	// Use this for initialization
	void Start () {
		//replaySystem = FindObjectOfType<ReplaySystem>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CrossPlatformInputManager.GetButton ("Fire1")) {
			recordOn = false;
		} else {
			recordOn = true;
		}
//		if (recordOn) {
//			print ("RECORD OFF");
//			replaySystem.PlayBack();
//		} else {
//			print ("RECORD ON");
//			replaySystem.Record();
//		}
	}
}
