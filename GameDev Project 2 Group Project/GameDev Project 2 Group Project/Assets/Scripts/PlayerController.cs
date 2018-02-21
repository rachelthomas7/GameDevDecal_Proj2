using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float flyForce; // controls the magnitude of the flying action.
	// Use this for initialization
	private Rigidbody myRigidBody;
	public float playerSpeed; //controls forwards speed of player
	public Vector3 playerPos; // position of player
	private Quaternion startRot; // saves starting rotation of player, so it doesn't change
	public int life; // maybe have some life points so that bat will die after hitting wall certain number of times

	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();
		playerPos = transform.position;
		startRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
			playerPos = transform.position;
			transform.rotation = startRot;
			myRigidBody.velocity = new Vector3 (myRigidBody.velocity.x, myRigidBody.velocity.y, playerSpeed);
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) { 
				// flap wings + go up
				myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y+flyForce, playerSpeed);
			}
			if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) { 
				//go up + left
				myRigidBody.velocity = new Vector3(myRigidBody.velocity.x-flyForce/2, myRigidBody.velocity.y+flyForce, playerSpeed);
			}
			if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) { 
				// go up + right
				myRigidBody.velocity = new Vector3(myRigidBody.velocity.x+flyForce/2, myRigidBody.velocity.y+flyForce, playerSpeed);
			}
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) { 
				// go down
				myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y-flyForce/4, playerSpeed);
			}
		
	}

}

