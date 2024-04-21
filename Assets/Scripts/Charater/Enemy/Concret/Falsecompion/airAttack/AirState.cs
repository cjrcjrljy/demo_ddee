using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirState : Fouc
{
    public AirState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName) : base(stateMahine, enemy, animatorName)
    {
    }
    public float jumphei;
    public override void Enter()
    {
        enemy.Setvelocity(movespeed / 1.2f * enemy.Facingdir, jumphei);
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
