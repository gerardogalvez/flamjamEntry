using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D co){
		if (co.gameObject.tag == "Platform") {
			Player.isOnPlatform = true;
		} else if (co.gameObject.tag == "Killzone")
			Application.LoadLevel ("Score");
	}
	
	void OnCollisionExit2D(Collision2D co){
		if (co.gameObject.tag == "Platform"){
			Player.isOnPlatform = false;
		}
	}
}
