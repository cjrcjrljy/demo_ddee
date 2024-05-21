using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_ani :Ene_ani
{
    public AudioSource audio;
    public AudioClip Attack;
    public StoneEnemy stoneEnemy;
    public GameObject Soul;
    public GameObject Locat;
    public int much;
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
    public void HeavyShke()
    {
        AttackSense.Instance.HitPause(demo.pauseTime);
        AttackSense.Instance.Hitshake(demo.shakeTime, demo.strengh+3);
    }
    public void RelaseSuol()
    {
        StartCoroutine(release());
    }
    IEnumerator release()
    {
        for(int i=0;i<much; i++)
        {
            yield return new WaitForSeconds(1f);
            poolmanager.Release(Soul, Locat.transform.position);
        }
    }
    public void FACEPLAYER()
    {
        stoneEnemy.FacingPlayer();
    }
}