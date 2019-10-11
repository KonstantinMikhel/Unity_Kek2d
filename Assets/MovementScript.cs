using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
	
	public float speed = 1f;

	public Rigidbody2D rb;

	public GameObject ground;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		if (ground == null) {
			ground = GameObject.FindWithTag ("Ground");
		}
	}

	void Update () {

		//CharacterController controller = GetComponent<CharacterController>();
		// OnCollisionEnter

		Vector2 force = new Vector2 (0.0f, 15000.0f); 
		bool jump = Input.GetKeyDown (KeyCode.UpArrow);
		if (jump && true) {
			rb.AddForce (force);
		}

		float h = Input.GetAxisRaw("Horizontal");

		gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), 
			transform.position.y);
	}
}
