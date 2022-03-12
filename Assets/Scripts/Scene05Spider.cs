using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene05Spider : MonoBehaviour
{
    private Rigidbody2D rb;
    public float totalTime7;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Scale();
        Jump();
    }

    void Jump()
    {
        if (totalTime7 < 100)
        {
            totalTime7 += Time.deltaTime;
        }
        if (totalTime7 > 5)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
    }
    void Scale()
    {
        if (rb.velocity.x > 0)
        {
            rb.transform.localScale = new Vector2(-0.1f, 0.1f);
        }
        if (rb.velocity.x < 0)
        {
            rb.transform.localScale = new Vector2(0.1f, 0.1f);
        }
    }
}
