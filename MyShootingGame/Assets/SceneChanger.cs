using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void SceneChange() 
    {
        SceneManager.LoadScene("Play");  // using UnityEngine.SceneManagement
    }
}
