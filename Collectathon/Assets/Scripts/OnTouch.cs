using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnTouch : MonoBehaviour
{
    public SoundManager sm;
    [SerializeField] private GameObject bridge;
    [SerializeField] private Canvas resultCanvas;
    [SerializeField] private TextMeshProUGUI result;
    private GameManager _gameManager;
    private void Awake()
    {
        bridge.SetActive(false);
    }

    private void Start()
    {
        sm = FindObjectOfType<SoundManager>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            //cancel invoke
            _gameManager.Win();
        }

        if (other.gameObject.CompareTag("BridgeButton"))
        {
            sm.PlayBridge();
            bridge.SetActive(true);
        }

    }
    
}
