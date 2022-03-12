using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator spiderAnim;
    SpiderController spiderController;

    void Start()
    {
        spiderAnim = GetComponent<Animator>();
        spiderController = GetComponent<SpiderController>();
    }

    // Update is called once per frame
    void Update()
    {
        spiderAnim.SetBool("attack", spiderController.isAttack);
        spiderAnim.SetBool("act", spiderController.isAct);
        spiderAnim.SetFloat("speed", Mathf.Abs(spiderController.xVelocity));
    }


}
