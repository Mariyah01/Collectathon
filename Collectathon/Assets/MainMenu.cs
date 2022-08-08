using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    [SerializeField] private Canvas howTo;
    [SerializeField] private Canvas main;

    private void Awake()
    {
        howTo = GameObject.FindGameObjectWithTag("HowToCanvas").GetComponent<Canvas>();
        howTo.enabled = false;
    }
    

    public void PlayGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void ShowHow()
    {
        main = GameObject.FindGameObjectWithTag("MenuCanvas").GetComponent<Canvas>();
        howTo = GameObject.FindGameObjectWithTag("HowToCanvas").GetComponent<Canvas>();
        main.enabled = false;
        howTo.enabled = true;
    }

    public void BackToMain()
    {
        main = GameObject.FindGameObjectWithTag("MenuCanvas").GetComponent<Canvas>();
        howTo = GameObject.FindGameObjectWithTag("HowToCanvas").GetComponent<Canvas>();
        howTo.enabled = false;
        main.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
