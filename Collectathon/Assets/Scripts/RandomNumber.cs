using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private int randomNumber;

    // Update is called once per frame
    void Update()
    {
        text.text=($"{randomNumber}");
    }

    public void ChangeNumber()
    {
        randomNumber = Random.Range(1, 101);
    }
}
