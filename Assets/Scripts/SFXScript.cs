using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public static SFXScript instance;

    public AudioClip musicClip;
    public AudioSource musicSource;

    void Start()
    {
        instance = this;
        musicSource.clip = musicClip;
    }

    public void PlaySFX()
    {
        musicSource.Play();
    }
}
