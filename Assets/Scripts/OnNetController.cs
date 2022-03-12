using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnNetController : MonoBehaviour
{
    Animator net;
    void Start()
    {
        net = GetComponent<Animator>();
        
    }


    void Update()
    {
        net.SetBool("net_netted", true);
    }
}
