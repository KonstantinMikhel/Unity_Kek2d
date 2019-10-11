using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
	
	public float speed = 1f;

	public Rigidbody2D rb;

	public GameObject ground;

	//находится ли персонаж на земле или в прыжке?
	private bool isGrounded = true;
	//радиус определения соприкосновения с землей
	private float groundRadius = 0.75f;
	//ссылка на слой, представляющий землю
	public LayerMask whatIsGround;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		if (ground == null) {
			ground = GameObject.FindWithTag ("Ground");
		}
	}

	void Update () {
		
		Vector2 force = new Vector2 (0.0f, 15000.0f); 
		bool jump = Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
		if (jump && Physics2D.OverlapCircle(gameObject.transform.position, groundRadius, whatIsGround)) {
			rb.AddForce (force);
		}

		float h = Input.GetAxisRaw("Horizontal");

		print("Кек лол");

		gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), 
			transform.position.y);
	}
}
