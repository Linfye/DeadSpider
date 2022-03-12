using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtSpiderController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;
    public float xVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        GroundMovement();
        GroundDirection();
    }

    void GroundMovement()
    {
        xVelocity = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);


    }

    void GroundDirection()
    {
        if (xVelocity < 0)
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        if (xVelocity > 0)
        {
            transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
        }
    }

}
