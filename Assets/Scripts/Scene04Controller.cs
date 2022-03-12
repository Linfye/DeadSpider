using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene04Controller : MonoBehaviour
{
    public GameObject tear1;
    public GameObject tear2;
    public GameObject spider;
    public GameObject root;
    public GameObject water;
    public float tearShow;
    public GameObject BackgroundBranches;
    public GameObject Leaves;

    
    void Start()
    {
        
    }


    void Update()
    {
        ChangeSC();
        if (tearShow < 70) 
        {
            tearShow += Time.deltaTime;
        }
        if (tearShow > 10)
        {
            tear1.SetActive(true);
        }
        if(tearShow > 16)
        {
            spider.SetActive(false);
            root.SetActive(true);
        }
        if (tearShow > 18)
        {
            tear2.SetActive(true);
        }
        if (tearShow > 23)
        {
            Destroy(tear2);
            water.SetActive(true);
        }
        if (tearShow > 27)
        {
            root.SetActive(false);
            water.SetActive(false);
            spider.SetActive(true);
            BackgroundBranches.SetActive(false);
            Leaves.SetActive(false);

        }

    }

    void ChangeSC()
    {
        if (tearShow > 50)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
