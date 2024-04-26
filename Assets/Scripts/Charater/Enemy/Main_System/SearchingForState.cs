using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 普通敌人才有的巡逻状态，boss默认知道player的位置
/// </summary>
public class SearchingForState : EnemyState
{
    public SearchingForState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName) : base(stateMahine, enemy, animatorName)
    {
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
        enemyBase.Setvelocity(enemyBase.Movespeed* enemyBase.Facingdir, enemyBase.rb.velocity.y);
        if (enemyBase.IsFindPlayer)
        {
            enemyBase.StateMachine.ChangeState(enemyBase.fouc);

        }
        base.Update();
    }
}
