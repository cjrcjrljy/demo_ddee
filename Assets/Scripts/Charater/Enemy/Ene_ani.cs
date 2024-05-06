using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_ani : MonoBehaviour
{
    public Enemy demo;
    public Animator animator;
    public virtual void Awake()
    {
        animator=GetComponent<Animator>();
        demo = GetComponentInParent<Enemy>();
    }
    public virtual void TriggerOut()
    {
        demo.StateMachine.CurrrentState.TriggerCalled = true;
    }
    public virtual void AttackShake()
    {
        AttackSense.Instance.HitPause(demo.pauseTime);
        AttackSense.Instance.Hitshake(demo.shakeTime,demo.strengh);
    }
}
