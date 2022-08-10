using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource _musicSource;
    
    public AudioSource _effectsSource;

    public AudioClip playerJump, coinCollect, winSound, loseSound, bridge;

    public static SoundManager instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void PlayPlayerJump()
    {
        _effectsSource.PlayOneShot(playerJump);
    }

    public void PlayCoinCollect()
    {
        _effectsSource.PlayOneShot(coinCollect);
    }

    public void PlayWinSound()
    {
        _effectsSource.PlayOneShot(winSound);
    }
    
    public void PlayLoseSound()
    {
        _effectsSource.PlayOneShot(loseSound);
    }

    public void PlayBridge()
    {
        _effectsSource.PlayOneShot(bridge);
    }
}
