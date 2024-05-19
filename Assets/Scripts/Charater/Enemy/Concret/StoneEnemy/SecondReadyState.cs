using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondReadyState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public SecondReadyState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName,StoneEnemy _enemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
       
    }
    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
        {
            stateMahine.ChangeState(stoneEnemy.secondState);
        }
    }
    public override void Exit()
    {
        base.Exit();
        poolmanager.Release(stoneEnemy.Boom,stoneEnemy.animator.transform.position);
    }


}
