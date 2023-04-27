using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int currentScore = 0;
    public int maxScore;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI maxScoreText;

    public const string MAX_SCORE_KEY = "MaxScore";

    private void Awake()
    {
        maxScore = PlayerPrefs.GetInt(MAX_SCORE_KEY);
        maxScoreText.text = maxScore.ToString();
    }

    private void Update()
    {
        if (currentScore > maxScore)
        {
            maxScore = currentScore;
            maxScoreText.text = maxScore.ToString();
        }
    }


    public void AddPoints()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }

}
