using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource _audioSource;

    public AudioClip playerJump, coinCollect, winSound, bridge;

    public static SoundManager instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayPlayerJump()
    {
        _audioSource.PlayOneShot(playerJump);
    }

    public void PlayCoinCollect()
    {
        _audioSource.PlayOneShot(coinCollect);
    }

    public void PlayWinSound()
    {
        _audioSource.PlayOneShot(winSound);
    }

    public void PlayBridge()
    {
        _audioSource.PlayOneShot(bridge);
    }
}
