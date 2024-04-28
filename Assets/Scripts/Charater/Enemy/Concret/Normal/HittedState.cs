using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittedState : AllLessState
{
    public HittedState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Enemy_Demo demo) : base(stateMahine, enemy, animatorName, demo)
    {
    }

    public override void Enter()
    {
        base.Enter();
        demo.Setvelocity(demo.HittedDis * (-1) * demo.Facingdir, demo.rb.velocity.y);
    }

    public override void Exit()
    {
        base.Exit();
        demo.IsHitted = false;
    }

    public override void Update()
    {
        if(TriggerCalled)
        {
            stateMahine.ChangeState(demo.searchingstate);
        }
        base.Update();
    }
}