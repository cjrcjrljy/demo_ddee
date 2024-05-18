using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFX : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        audio.clip = clip;
        audio.Play();
    }
}
