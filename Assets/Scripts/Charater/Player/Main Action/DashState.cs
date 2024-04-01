using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : PlayerState
{
    public DashState(Player _player, PlayerStateMachine _statemachine, string _animator) : base(_player, _statemachine, _animator)
    {
    }
    public int Dashspeed = 3;
    public int facdir = 1;
    public override void Enter()
    {
        player.Hleath.CanbeAttacked = false;
        base.Enter();
     
    }

    public override void Exit()
    {
        base.Exit();
        player.Hleath.CanbeAttacked = true;
        Debug.Log("OUT");
    }

    public override void Update()
    {
        Debug.Log(Xinput);
        if(Input.GetKeyDown(KeyCode.E)) {
            TriggerCalled = true;
        }
        if (TriggerCalled)
            player.stateMachine.ChangeState(player.IdleState);
        base.Update();
    }
}

