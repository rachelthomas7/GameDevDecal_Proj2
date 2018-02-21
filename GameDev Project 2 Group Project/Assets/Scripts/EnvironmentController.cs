using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour {
	// this class is to control the behavior of the tunnel. We have two options for the control of the game:
	// option 1 is the player & camera are stationery (relative to unity global space) and the tunnel, obstacles and bugs generate, move towards them and are deleted as they pass the camera
	// benefits of option 1 are that it's probably more efficient + better in general 
	// option 2 is the player and camera move through a stationary tunnel & objects + bugs are also stationary. 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
