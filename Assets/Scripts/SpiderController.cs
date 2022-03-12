using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpiderController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;
    public bool isAttack;
    public bool isAct;
    public float xVelocity;//x轴移动方向
    public bool isSpider_Fly;

    Timer timer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = GetComponent<Timer>();
    }

    
    void Update()
    {
        GroundMovement();
        GroundDirection();
        Attack();
        Act();

        FlashBack();
        Net();
    }

    //地面移动
    void GroundMovement()
    {
        xVelocity = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);


    }

    //地面转向
    void GroundDirection()
    {
        if (xVelocity < 0)
        {
            transform.localScale =new Vector3(-0.2f, 0.2f, 0.2f);
        }
        if (xVelocity > 0)
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
    }

    //按住空格攻击攻击
    void Attack()
    {
        if (Input.GetButton("Attack"))
        {
            isAttack = true;
        }
        else
        {
            isAttack = false;
        }
    }

    //长按f织网或进食
    void Act()
    {
        if (Input.GetButton("Act"))
        {
            isAct = true;
        }
        else
        {
            isAct = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            isSpider_Fly = true;
        }
    }

    void FlashBack()
    {
        if (timer.flashBack)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Net()
    {
        if (timer.isNet)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void LittleSpider()
    {
        if (timer.littleSpider)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Teleport()
    {
        GameObject.Find("Fly").GetComponent<FlyController>().Teleport();
    }

}
