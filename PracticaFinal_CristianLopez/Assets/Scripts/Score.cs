using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour

{

    private int score;
    

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI recordText;

    private void Awake()
    {
        score = 0;
        recordText.text = PlayerPrefs.GetInt("Record", 0).ToString();

    }


    private void Update()
    {
        NewRecord();
    }

    private void NewRecord()
    {
        if (score > PlayerPrefs.GetInt("Record",0))
        {
            PlayerPrefs.SetInt("Record", score);
            recordText.text = PlayerPrefs.GetInt("Record", 0).ToString();

        }
    }

    public void RestartRecord()
    {
        PlayerPrefs.SetInt("Record", 0);
        recordText.text = PlayerPrefs.GetInt("Record", 0).ToString();
    }


    public void AddPoints()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
