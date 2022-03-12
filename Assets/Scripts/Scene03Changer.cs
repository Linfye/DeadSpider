using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene03Changer : MonoBehaviour
{
    public float time03;
    void Start()
    {
        
    }


    void Update()
    {
        time03 += Time.deltaTime;
        if (time03 > 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
