using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject timer;
    public bool isNight;
    public float speed = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        isNight = timer.GetComponent<Timer>().isNight;
        IsNight();
    }

    void IsNight()
    {
        if (isNight)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        }

        if(rb.position.z > 10)
        {
            speed = 0;
        }
    }
}
