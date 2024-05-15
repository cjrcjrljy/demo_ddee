using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager :PersistentSingleton<AudioManager>
{
    public AudioSource SFXPlayer;
    public float MIN_PIT=0.9f;
    public float MAX_PIT=1.1f;
    public void PlaySFX(AudioClip SFX,float volume)
    {
        SFXPlayer.PlayOneShot(SFX,volume);
    }
    public void PlayRandom(AudioClip RandomSFX,float volume)
    {
        SFXPlayer.pitch = Random.Range(MIN_PIT,MAX_PIT);
         PlaySFX(RandomSFX,volume); 
    }
}
