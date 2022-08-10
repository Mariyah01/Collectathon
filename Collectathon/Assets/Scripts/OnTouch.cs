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
    private void Awake()
    {
        bridge.SetActive(false);
    }

    private void Start()
    {
        sm = FindObjectOfType<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            result.text = "You won!";
            resultCanvas.enabled = true;
            sm.PlayWinSound();
        }

        if (other.gameObject.CompareTag("BridgeButton"))
        {
            sm.PlayBridge();
            bridge.SetActive(true);
        }

    }
    
}
