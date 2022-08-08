using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI healthValue;
    private int health = 100;

    // Update is called once per frame
    void Update()
    {
        healthValue.text = ($"{health}");

        if (health <= 0)
            Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            health -= 10;
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
