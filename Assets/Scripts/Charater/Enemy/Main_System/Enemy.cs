using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Enity
{
    public EnemyStateMahine StateMachine;
    public bool trigger;
    public override void Awake()
    {
        base.Awake();
        animator = GetComponentInChildren<Animator>();
        trigger = false;
        StateMachine =new EnemyStateMahine();
    }
    public void Update()
    {
       
        StateMachine.CurrrentState.Update();
    }
}
