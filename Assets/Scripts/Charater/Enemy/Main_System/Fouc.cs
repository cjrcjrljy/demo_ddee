using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fouc : EnemyState
{
    public Fouc(EnemyStateMahine stateMahine, Enemy enemy, string animatorName) : base(stateMahine, enemy, animatorName)
    {
    }

    public override void Enter()
    {
        enemyBase.Setvelocity(enemyBase.Movespeed * 3.2f * enemyBase.Facingdir, enemyBase.rb.velocity.y);
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        enemyBase.FacingPlayer();
      
        base.Update();
    }
}
