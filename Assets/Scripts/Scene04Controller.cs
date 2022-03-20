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
        if (tearShow > 10 && tearShow < 11)
        {
            tear1.SetActive(true);
        }
        if(tearShow > 16 && tearShow < 17)
        {
            spider.SetActive(false);
            root.SetActive(true);
        }
        if (tearShow > 18 && tearShow < 19)
        {
            tear2.SetActive(true);
        }
        if (tearShow > 23 && tearShow < 24)
        {
            Destroy(tear2);
            water.SetActive(true);
        }
        if (tearShow > 26 && tearShow < 27)
        {
            Debug.Log("233");
            Destroy(root);
            Destroy(water);
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
