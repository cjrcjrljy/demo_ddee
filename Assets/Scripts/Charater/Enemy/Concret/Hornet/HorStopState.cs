using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorStopState : EnemyState
{
    public Horent horent;
    public HorStopState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
    }

    public override void Enter()
    {
        base.Enter();
        StateTimer = horent.stopDector.StopTime;
        Debug.Log(StateTimer);
        horent.stopDector.canbeHitted = false;
    }

    public override void Exit()
    {
        horent.stopDector.canbeHitted=true;
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        Debug.Log("stop");
        StateTimer-=Time.deltaTime;
        if (StateTimer < 0)
            stateMahine.ChangeState(horent.fitstState);
    }
}
