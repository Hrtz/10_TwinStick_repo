﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames = 1000;
	private MyKeyFrame[] keyFrames = new MyKeyFrame [bufferFrames];
	private Rigidbody rigidbody;
	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		gameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameManager.recordOn) {
			Record ();
		} else {
			PlayBack ();
		}
	}

	void PlayBack () {
		rigidbody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		//print ("Reading frame " + frame);
		transform.position = keyFrames [frame].position;
		transform.rotation = keyFrames [frame].rotation;
	}

	void Record ()
	{
		rigidbody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		//print ("Writing frame " + frame);
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A structure for storing time, rotation and postition
/// </summary>
public struct MyKeyFrame {
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame (float aTime, Vector3 aPosition, Quaternion aRotation){
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;
	}
}
