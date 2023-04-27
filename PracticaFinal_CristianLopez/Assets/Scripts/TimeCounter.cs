using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    // Contador de tiempo
    [SerializeField] private float countDownTime = 30;
    private float timeRemaining = 0; 
    public TextMeshProUGUI timer; 
    
    private void Start()
    {
        timeRemaining = countDownTime;
        timer.text = timeRemaining.ToString("00");
    }
    private void Update()
    {
        timeRemaining -= Time.deltaTime;
        timer.text = timeRemaining.ToString("00");

        if (timer.text ==("00"))
        {
            SceneManager.LoadScene("End");
        }
    }
}

