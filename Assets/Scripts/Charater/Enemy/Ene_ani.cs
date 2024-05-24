using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_ani : MonoBehaviour
{
    public Enemy demo;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator=GetComponent<Animator>();
        demo = GetComponentInParent<Enemy>();
    }
    public virtual void TriggerOut()//最标准的状态切换
    {
        demo.StateMachine.CurrrentState.TriggerCalled = true;
    }
    public virtual void AttackShake()
    {  
        AttackSense.Instance.HitPause(demo.pauseTime);
        AttackSense.Instance.Hitshake(demo.shakeTime, demo.strengh);
    }
    public virtual void DisOut()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
       spriteRenderer.sprite=null;
    }
}
