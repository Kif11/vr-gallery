﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PaintingCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") || Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("gallery");
		}
	
	}
}
