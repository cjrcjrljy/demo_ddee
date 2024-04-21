using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        base.Update();
    }
}
