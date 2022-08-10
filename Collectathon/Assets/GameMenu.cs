using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private string mainScene;
    [SerializeField] private Canvas resultCanvas;

    private void Awake()
    {
        resultCanvas.enabled = false;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMain()
    {
        SceneManager.LoadScene(mainScene);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    
}
