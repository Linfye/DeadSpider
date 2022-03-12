using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalTime2Controller : MonoBehaviour
{
    public float totalTime2;
    public bool isNet;

    // Update is called once per frame
    void Update()
    {
        Scene02Controller();
    }

    void Scene02Controller()
    {
        if (totalTime2 < 70)
        {
            totalTime2 += Time.deltaTime;
        }
        if (totalTime2 > 60)
        {
            isNet = true;
        }
    }
}
