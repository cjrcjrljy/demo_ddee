using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState
{
    public EnemyStateMahine stateMahine;
    public Enemy enemyBase;
    public bool TriggerCalled;
    public string AnimatorName;
    public float StateTimer;
    public bool Focus;

    public float movespeed;

    public EnemyState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName)
    {
        this.stateMahine = stateMahine;
        this.enemyBase = enemy;
        AnimatorName = animatorName;
    }

    public virtual void Enter()
    {
        TriggerCalled = false;
        enemyBase.animator.SetBool(AnimatorName, true);

    }
    public virtual void Update()
    {
        StateTimer-= Time.deltaTime;
        if(enemyBase.IsFindPlayer)
        {
 
            enemyBase.StateMachine.ChangeState(enemyBase.fouc);

        }
    }
    
    public virtual void Exit()
    {
        enemyBase.animator.SetBool(AnimatorName, false);
    }

}

