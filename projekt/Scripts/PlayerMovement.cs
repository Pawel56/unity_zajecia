using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    float horizontalInput;
    float verticalInput;
    public Rigidbody2D rb;
    void Start()
    {
        //rb = gameObject.AddComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput, verticalInput) * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            transform.position = new Vector2(0,0);
        }
    }
}
