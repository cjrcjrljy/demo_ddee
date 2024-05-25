using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallState : EnemyState
{
    public Horent horent;

    public FallState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName,Horent _ho) : base(stateMahine, enemy, animatorName)
    {
        horent = _ho;
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
        if (horent.IsGrounded)
            stateMahine.ChangeState(horent.gap);
    }
}
