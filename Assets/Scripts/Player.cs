using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10.0f;
	public float jumpForce;
	public static bool isOnPlatform = true;

	// Use this for initialization
	void Start () {
		jumpForce = 500f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement ();
	}

	void Movement(){
		this.transform.Translate (Vector2.right * speed * Time.deltaTime);
		//Jump
		if (Input.GetKeyDown ("space") && isOnPlatform) {
			//this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 6f);
		}
	}
}
