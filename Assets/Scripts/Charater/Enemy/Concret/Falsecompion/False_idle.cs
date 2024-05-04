using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False_idle : EnemyState
{
    public false_champion false_;
    public False_idle(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, false_champion false_) : base(stateMahine, enemy, animatorName)
    {
        this.false_ = false_;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
       
        //if (enemyBase.IsFindPlayer_grou)
        //{
        //    enemyBase.StateMachine.ChangeState(enemyBase.fouc);

        //}
        base.Update();
    }
}

