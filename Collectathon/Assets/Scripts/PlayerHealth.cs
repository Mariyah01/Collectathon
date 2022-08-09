using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    //[SerializeField] private TextMeshProUGUI healthValue;
    [SerializeField] private float health=1;

    // Update is called once per frame
    void Update()
    {
        //healthValue.text = ($"{health}");
        healthBar.fillAmount = health;

        if (health <= 0)
            Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            health -= 0.1f;
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
