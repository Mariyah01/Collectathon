using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private int timeLeft;

    private void Start()
    {
        InvokeRepeating("Countdown",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = ($"{timeLeft}");
        
        if(timeLeft<=0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Countdown()
    {
        timeLeft--;
    }
}
