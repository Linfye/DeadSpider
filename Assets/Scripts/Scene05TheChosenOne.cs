using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene05TheChosenOne : MonoBehaviour
{
    private Rigidbody2D rb;
    public float totalTime7;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        JumpTheChosenOne();
        Scale();
    }
    void JumpTheChosenOne()
    {
        if (totalTime7 < 100)
        {
            totalTime7 += Time.deltaTime;
        }
        if (totalTime7 > 5)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
        if (totalTime7 > 21)
        {
            rb.velocity = new Vector2(0, 0);
        }
        if (totalTime7 > 26)
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
        }
        if (totalTime7 > 37)
        {
            rb.velocity = new Vector2(0, 0);
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
