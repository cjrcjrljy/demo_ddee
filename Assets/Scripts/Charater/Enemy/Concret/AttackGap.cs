using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGap : EnemyState
{
    public Horent horent;
    public AttackGap(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
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
        if (TriggerCalled)
            stateMahine.ChangeState(horent.fitstState);
    }
}
