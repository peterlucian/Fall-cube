using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public float score;

    void Start()
    {
        score = PlayerPrefs.GetFloat("Score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        PlayerPrefs.SetFloat("Score", score);
    }

    public void addScore()
    {
        score++;
    }
}
