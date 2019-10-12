using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    Rigidbody2D rigidbody;
    public float speed = 10f;
    private bool isGrounded = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }

    void Start()
    {
        rigidbody = GetComponent <Rigidbody2D>();
    }

    void Update()
    {
        float horizontalDirection = Input.GetAxis ("Horizontal");
        rigidbody.velocity = new Vector3 (horizontalDirection * speed, 0, 0);

        if (Input.GetKeyDown (KeyCode.Space) && isGrounded)
        {
            rigidbody.AddForce(new Vector3 (0, 15000, 0));
        }
    }
}
