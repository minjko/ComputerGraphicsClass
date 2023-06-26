using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text score;
    int count;

    void Start()
    {
        count = 0;    
        score = GameObject.Find("Score").GetComponent<Text>();
    }


    void Update()
    {
        
    }


    public void IncScore()
    {
        count++;
        this.score.text = count.ToString();

        if (count >= 5) 
        {
            SceneManager.LoadScene("0Title");
        }
    }
}
