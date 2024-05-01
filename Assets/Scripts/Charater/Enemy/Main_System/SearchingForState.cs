using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 普通敌人才有的巡逻状态，boss默认知道player的位置
/// </summary>
public class SearchingForState :AllLessState
{
    public SearchingForState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, NormalEnemy normalEnemy) : base(stateMahine, enemy, animatorName, normalEnemy)
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
        base.Update();
        if (!enemyBase.IsGrounded)
            enemyBase.Filp();
        enemyBase.Setvelocity(enemyBase.Movespeed * enemyBase.Facingdir, enemyBase.rb.velocity.y);
        if (enemyBase.IsFindPlayer_grou||enemyBase.IsFindPlayer_air)
        {
            enemyBase.StateMachine.ChangeState(enemyBase.fouc);

        }
        base.Update();
    }
}
