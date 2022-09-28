using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScripts : MonoBehaviour
{
    private int Score;

    private int _score = 0;

    public Text ScoreText;

    public void AddScore()
    {
        _score += 3;
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + _score.ToString();
        if (_score >= 100)
        {
            SceneManager.LoadScene("GOAL");
        }
    }
}
