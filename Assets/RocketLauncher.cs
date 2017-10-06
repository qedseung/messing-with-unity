using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {

	public bool launched = false;
	public Transform rocket;
	// Use this for initialization
	void OnTriggerEnter (Collider col) {
		print ("Launch Rocket");
		launched = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (launched) {
			rocket.position = new Vector3 (rocket.position.x, rocket.position.y + 1f, rocket.position.z);
		}
	}
}
