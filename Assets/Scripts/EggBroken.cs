using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBroken : MonoBehaviour
{
    Animator anim;
    public GameObject unseen;
    bool netbagBroken;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        netbagBroken = unseen.GetComponent<TotalTime5Controller>().netbagBroken;
        if (netbagBroken)
        {
            anim.SetBool("broken", true);
        }
    }
}
