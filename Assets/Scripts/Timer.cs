using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject netController;
    public bool isSpider_Net;

    SpiderController spiderController;

    public GameObject totalTime2Controller;

    public float totalTime1;

    public bool isNight;

    public bool flashBack;
    public bool isLightningBolt;

    public bool layEggs;
    public bool isNet;
    public bool netbagBroken;
    public bool littleSpider;

    void Start()
    {
        spiderController = GetComponent<SpiderController>();
    }


    void Update()
    {
        Scene01();
        Scene02();
        isSpider_Net = netController.GetComponent<NetController>().isSpider_Net;
        
    }

    void Scene01()
    {
        if (spiderController.isSpider_Fly && totalTime1 < 100)
        {
            totalTime1 += Time.deltaTime;
        }
        if (totalTime1 > 30)
        {
            isNight = true;
        }
        if (totalTime1 > 60)
        {
            isLightningBolt = true;
        }
        if (totalTime1 > 70)
        {
            flashBack = true;
        }
    }

    void Scene02()
    {
        isNet = totalTime2Controller.GetComponent<TotalTime2Controller>().isNet;
    }

}
