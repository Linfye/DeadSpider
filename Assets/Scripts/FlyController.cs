using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    Animator flyAnim;
    private Rigidbody2D rb;
    Transform flyTransform;

    public GameObject spider;
    public Transform spiderTransform;

    public bool isAttack;
    public bool isAct;
    public bool isSpider_Fly;

    public int direction;
    void Start()
    {
        flyAnim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        flyTransform = this.transform;


    }

    void Update()
    {
        isAttack = spider.GetComponent<SpiderController>().isAttack;
        isAct = spider.GetComponent<SpiderController>().isAct;
        isSpider_Fly = spider.GetComponent<SpiderController>().isSpider_Fly;



        isKiiled();
        isWrapped();
        isEaten();
    }

    
    public void Teleport()
    {
        int Direction(int x)
        {
            if (spider.transform.localScale.x > 0)
            {
                direction = 1;

            }
            if (spider.transform.localScale.x < 0)
            {
                direction = -1;

            }
            return direction;
        }
        if (isSpider_Fly)
        {
                flyTransform.position = new Vector3(spiderTransform.position.x + Direction(direction) * 0.5f, spiderTransform.position.y - 3f, spiderTransform.position.z);
        }
    }
    void isKiiled()
    {
        if (isAttack && isSpider_Fly)
        {
            flyAnim.SetBool("killed", true);
        }
    }

    void isWrapped()
    {
        if (isAct)
        {
            flyAnim.SetBool("wrapped", true);
        }

    }

    void isEaten()
    {
        if(flyAnim.GetBool("wrapped") && isAct)
        {
            flyAnim.SetBool("eaten", true);
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
