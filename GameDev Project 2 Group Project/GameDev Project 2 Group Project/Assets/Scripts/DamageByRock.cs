using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByRock : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Wall")
		{
			//detected the bat hit the wall.. now take damage
			
		}
	}
}
