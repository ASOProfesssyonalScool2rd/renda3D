using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Scripts : MonoBehaviour
{
    private int _score = 0;
    public Text scoreText;

    public void AddScore()
    {
        _score++;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE:"  + _score.ToString();
    }
}
