using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	//this class is to help control the general details of the game, namely score,
	// game wins & losses. 
	// ALSO: controls generation of tunnel + bugs + obstacles 
	public Vector3 generatePosition;
	public Vector3 playerPosition;
	public GameObject player;
	public double tunnelWidth;//width of tunnel, making public so it's adjustable
	public double tunnelSpeed;//speed of player thru tunnel; also amount tunnel moves each frame
	private double timeToPassThruTunnel;
	public bool wonGame = false; 
	public int score;
//	private Queue tunnelHolder; do not need it!!!

	// Use this for initialization
	void Start () {
		generatePosition = new Vector3(0,0,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		playerPosition = player.transform.position;
		//update the generateposition to match 
		//use random number between 0-4 to generate next tunnel piece

	}
}
