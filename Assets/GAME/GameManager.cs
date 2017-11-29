using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recordOn = true;

	private GameObject textPause;
	private bool pauseOn;
	private float fixedDelta;

	//private ReplaySystem replaySystem;
	
	// Use this for initialization
	void Start () {
		pauseOn = false;
		fixedDelta = Time.fixedDeltaTime;
		textPause = GameObject.Find("TextPause");
		textPause.SetActive(false);
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

		if (!pauseOn && Input.GetKeyDown (KeyCode.P)) {
			PauseGame ();
		} else if (pauseOn && Input.GetKeyDown (KeyCode.P)) {
			ResumeGame ();
		}


//		if (recordOn) {
//			print ("RECORD OFF");
//			replaySystem.PlayBack();
//		} else {
//			print ("RECORD ON");
//			replaySystem.Record();
//		}
	}
	void PauseGame () {
		pauseOn = true;
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
		print ("pause");
		textPause.SetActive(true);
	}

	void ResumeGame () {
		pauseOn = false;
		Time.timeScale = 1f;
		Time.fixedDeltaTime = fixedDelta;
		textPause.SetActive(false);
	}

	void OnApplicationPause (bool pauseStatus)
	{	
		pauseOn = pauseStatus;
		if (pauseOn) {
			PauseGame ();
		}
	}
}
