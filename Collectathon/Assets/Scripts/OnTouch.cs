using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTouch : MonoBehaviour
{
    public SoundManager sm;
    [SerializeField] private GameObject bridge;
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.CompareTag("BridgeButton"))
        {
            sm.PlayBridge();
            bridge.SetActive(true);
        }

    }
    
}
