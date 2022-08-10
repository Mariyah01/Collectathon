using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    private void Start()
    {
        main = GameObject.FindGameObjectWithTag("MenuCanvas").GetComponent<Canvas>();
        howTo = GameObject.FindGameObjectWithTag("HowToCanvas").GetComponent<Canvas>();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void ShowHow()
    {
        main.enabled = false;
        howTo.enabled = true;
    }

    public void BackToMain()
    {
        howTo.enabled = false;
        main.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
