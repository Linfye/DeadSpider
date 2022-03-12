using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LittleSpiderController1 : MonoBehaviour
{
    public Transform hurtSpider;

    Transform littleSpiderTransform;
    private Rigidbody2D rb;

    public float LSTimer;


    [HideInInspector] public GameObject LS2;
    [HideInInspector] public GameObject LS3;
    [HideInInspector] public GameObject LS4;
    [HideInInspector] public GameObject LS5;
    [HideInInspector] public GameObject LS6;
    [HideInInspector] public GameObject LS7;
    [HideInInspector] public GameObject LS8;

    void Start()
    {
        littleSpiderTransform = this.transform;
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Movement();
        Scale();
        LS();
    }

    void Movement()
    {
        if (littleSpiderTransform.position.x > hurtSpider.position.x)
        {

            rb.velocity = new Vector2(-3, rb.velocity.y);
        }
        if (littleSpiderTransform.position.x < hurtSpider.position.x)
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

    void LS()
    {
        if (LSTimer < 100)
        {
            LSTimer += Time.deltaTime;
        }
            
        if (9 < LSTimer && LSTimer < 10) LS2.SetActive(true);
        if (14 < LSTimer && LSTimer < 15) LS3.SetActive(true);
        if (19 < LSTimer && LSTimer < 20) LS4.SetActive(true);
        if (24 < LSTimer && LSTimer < 25) LS5.SetActive(true);
        if (29 < LSTimer && LSTimer < 30) LS6.SetActive(true);
        if (34 < LSTimer && LSTimer < 35) LS7.SetActive(true);
        if (39 < LSTimer && LSTimer < 40) LS8.SetActive(true);
        if (LSTimer > 70) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
