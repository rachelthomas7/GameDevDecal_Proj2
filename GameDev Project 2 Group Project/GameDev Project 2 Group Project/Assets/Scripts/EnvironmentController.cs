using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour {
	// this class is to control the behavior of the tunnel. 

	// Use this for initialization
	public GameObject player;
	void Start () {
		// need to generate objects in the tunnel, as its children. 
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position [2] <= player.transform.position[2]-5){
			//if gameobject has passed view of the camera 
			Destroy (this.gameObject);
		}
	}
}
