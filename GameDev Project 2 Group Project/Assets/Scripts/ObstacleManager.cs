using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {
	// this class is for managing the creation / behavior of obstacles (stalagtites/stalagmites)
	// obstacles should generate randomly in tunnel. Stalagtites should generate on top of tunnel 
	// and stalagmites on the bottom. If the player collides with an obstacle 

	// Use this for initialization
	void Start () {
		// place obstacle randomly in generated tunnel
	}
	
	// Update is called once per frame
	void Update () {
		//if obstacle is collided with, decrease player's score (maybe handle this from player controller end)
	}
}
