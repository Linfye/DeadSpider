using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void suicide()
    {
        Destroy(gameObject);
    }
}
