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
//		PlayerPrefsManager.UnlockLevel(1);
//		print (PlayerPrefsManager.IsLevelUnlocked (0));
//		print (PlayerPrefsManager.IsLevelUnlocked (1));
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
