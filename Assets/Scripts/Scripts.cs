using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class Scripts : MonoBehaviour
{
    private int Score;
    private int _score = 0;
    public Text scoreText;

    public void AddScore()
    {
        _score+=5;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE:"  + _score.ToString();
        if (_score >=　50)
        {
            SceneManager.LoadScene("2ndSene");
        }
    }
}
