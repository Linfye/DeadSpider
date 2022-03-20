using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalTime5Controller : MonoBehaviour
{

    public float totalTime5;
    public bool netbagBroken;

    public GameObject littleSpider1;
    public GameObject Spider;
    public GameObject HurtSpider;

    void Update()
    {
        Scene05Controller();
    }

    void Scene05Controller()
    {
        if (totalTime5 < 40)
        {
            totalTime5 += Time.deltaTime;
        }
        if (totalTime5 >= 15)
        {
            littleSpider1.SetActive(true);
        }
        if (totalTime5 > 10)
        {
            netbagBroken = true;
            HurtSpider.transform.position = new Vector3 (Spider.transform.position.x, Spider.transform.position.y-6, Spider.transform.position.z);
            Destroy(Spider);
            HurtSpider.SetActive(true);
        }

    }

}
