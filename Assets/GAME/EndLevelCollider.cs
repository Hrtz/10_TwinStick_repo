using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelCollider : MonoBehaviour {

	private PlayerPrefsManager playerPrefsManager;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		playerPrefsManager = GameObject.FindObjectOfType<PlayerPrefsManager>();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.collider.name == "Player" ) {
			levelManager.LoadNextLevel();
		}
	}
}
