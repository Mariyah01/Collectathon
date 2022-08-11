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
    [SerializeField] private Canvas resultCanvas;
    public SoundManager sm;
    [SerializeField] private TextMeshProUGUI result;
    private bool lose=true;
    
    
    private void Start()
    {
        //Hello
        sm = FindObjectOfType<SoundManager>();
        InvokeRepeating("Countdown",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        //timer.text = ($"{timeLeft}");
        timePie.fillAmount = timeLeft;
        if (timeLeft <= 0 && lose)
        {
            lose = false;
            sm.PlayLoseSound();
            result.text = "You lost :(";
            resultCanvas.enabled = true;
        }
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Countdown()
    {
        timeLeft -= 0.01f;
    }

    public void Win()
    {
        CancelInvoke("Countdown");
        result.text = "You won!";
        resultCanvas.enabled = true;
        sm.PlayWinSound();
    }
}
