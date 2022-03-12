using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetController : MonoBehaviour
{
    public bool isSpider_Net;
    public bool isAct;

    public bool isNet;

    public GameObject spider;
    public GameObject net;
    public GameObject netBag;
    public GameObject Purple;
    public GameObject BG;
    public GameObject BlackBG;

    public float totalTime3;

    void Update()
    {

        isAct = spider.GetComponent<SpiderController>().isAct;
        Donet();
        NetBag();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isSpider_Net = true;
    }

    void Donet()
    {
        if (isSpider_Net && isAct)
        {
            net.SetActive(true);
            isNet = true;
        }
    }

    //◊œŒÌ
    void NetBag()
    {
        if (isNet)
        {
            totalTime3 += Time.deltaTime;
        }
        if (totalTime3 > 10)
        {
            Purple.SetActive(true);
        }

        if (isNet && totalTime3 > 18)//—” ±13s
        {
            netBag.SetActive(true);
            net.SetActive(false);

            BG.SetActive(false);
            BlackBG.SetActive(true);

        }

    }

}
