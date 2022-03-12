using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBoltController : MonoBehaviour
{
    public GameObject lightningBolt;
    public GameObject spider;

    public bool isLightningBolt;
    void Start()
    {
        
    }


    void Update()
    {
        LightningBolt();
        isLightningBolt = spider.GetComponent<Timer>().isLightningBolt;
        
    }

    void LightningBolt()
    {
        if (isLightningBolt)
        {
            lightningBolt.SetActive(true);
        }
    }

}
