using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private float timeLeft;
    [SerializeField] private Image timePie;

    private void Start()
    {
        InvokeRepeating("Countdown",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        //timer.text = ($"{timeLeft}");
        timePie.fillAmount = timeLeft;
        if(timeLeft<=0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Countdown()
    {
        timeLeft -= 0.01f;
    }
}
