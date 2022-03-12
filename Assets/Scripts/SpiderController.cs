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
    public float xVelocity;//x���ƶ�����
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

    //�����ƶ�
    void GroundMovement()
    {
        xVelocity = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);


    }

    //����ת��
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

    //��ס�ո񹥻�����
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

    //����f֯�����ʳ
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
