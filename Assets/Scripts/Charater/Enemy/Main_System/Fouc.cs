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
        Debug.Log("fff");
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        enemy.FacingPlayer();
        base.Update();
    }
}
