using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittedState : AllLessState
{
    public HittedState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, NormalEnemy normalEnemy) : base(stateMahine, enemy, animatorName, normalEnemy)
    {
    }

    public override void Enter()
    {
        base.Enter();
        NormalEnemy.Setvelocity(NormalEnemy.HittedDis * (-1) * NormalEnemy.Facingdir, NormalEnemy.rb.velocity.y);
    }

    public override void Exit()
    {
        base.Exit();
        NormalEnemy.IsHitted = false;
    }

    public override void Update()
    {
        if(TriggerCalled)
        {
            stateMahine.ChangeState(NormalEnemy.searchingForState);
        }
        base.Update();
    }
}