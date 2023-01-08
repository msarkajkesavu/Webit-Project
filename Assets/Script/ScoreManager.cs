using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText, highScoreText;
    public int score;
    int highScore;

    void Start()
    {
        // Load the score
        score = PlayerPrefs.GetInt("score");
        highScore = PlayerPrefs.GetInt("highScore");
        Debug.Log(score);

        // Update the score text
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    public void AddScore(int newScore)
    {
        // Add the new score to the current score
        score += newScore;

        // Update the score text
        scoreText.text = "Score: " + score;

        // Save the new score
        PlayerPrefs.SetInt("score", score);

        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore;

            // Save the new high score
            PlayerPrefs.SetInt("highScore", highScore);
        }

    }
}
