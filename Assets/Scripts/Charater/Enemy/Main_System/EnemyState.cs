using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState
{
    public EnemyStateMahine stateMahine;
    public Enemy enemy;
    public bool TriggerCalled;
    public string AnimatorName;
    public float StateTimer;
    public EnemyState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName)
    {
        this.stateMahine = stateMahine;
        this.enemy = enemy;
        AnimatorName = animatorName;
    }

    public virtual void Enter()
    {
        TriggerCalled = false;
        enemy.animator.SetBool(AnimatorName, true);

    }
    public virtual void Update()
    {
        StateTimer-= Time.deltaTime;
    }
    
    public virtual void Exit()
    {
        enemy.animator.SetBool(AnimatorName, false);
    }

}

