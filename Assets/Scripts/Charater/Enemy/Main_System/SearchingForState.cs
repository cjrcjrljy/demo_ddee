using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ͨ���˲��е�Ѳ��״̬��bossĬ��֪��player��λ��
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
