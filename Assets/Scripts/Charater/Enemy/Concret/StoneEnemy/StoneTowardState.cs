using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTowardState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public StoneTowardState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
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
        stoneEnemy.FacingPlayer();
        stoneEnemy.Setvelocity(stoneEnemy.Movespeed * stoneEnemy.Facingdir, stoneEnemy.rb.velocity.y);
        base.Update();
    }
}
