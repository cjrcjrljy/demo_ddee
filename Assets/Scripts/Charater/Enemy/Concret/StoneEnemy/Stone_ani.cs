using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_ani :Ene_ani
{
    public AudioSource audio;
    public AudioClip Attack;
    public StoneEnemy stoneEnemy;
    public override void Awake()
    {
        base.Awake();
        audio = GetComponent<AudioSource>();
        stoneEnemy = GetComponentInParent<StoneEnemy>();
    }
    public override void TriggerOut()
    {
        base.TriggerOut();
    }
    public void PlayeAttFx()
    {
        audio.clip = Attack;
        audio.Play();
    }
}