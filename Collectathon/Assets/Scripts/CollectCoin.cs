using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public SoundManager sm;
    [SerializeField] private GameObject tree;
    private int Coins=0;
    [SerializeField] private TextMeshProUGUI coinCounter;



    private void Awake()
    {
        tree.SetActive(false);
    }

    private void Start()
    {
        sm = FindObjectOfType<SoundManager>();
    }

    private void Update()
    {
        coinCounter.text = ($"{Coins}");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            sm.PlayCoinCollect();
            Coins++;
            Destroy(other.gameObject);
        }

        if (Coins == 20)
        {
            tree.SetActive(true);
        }

    }
}
