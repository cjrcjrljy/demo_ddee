using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DashState : PlayerState
{
    
    public int Dashspeed = 3;
    public int facdir = 1;
    public float current_Y;
    public DashState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        player.Hleath.CanbeAttacked = false;
        base.Enter();
        float dir=1;
        if (player.input.AxisX!=0)
             dir=player.input.AxisX/Mathf.Abs(player.input.AxisX);
        player.Setvelocity(Dashspeed *3f*dir, Dashspeed*3f*player.input.AxisY);
        current_Y=player.rb.velocity.y;
    }

    public override void Exit()
    {
        base.Exit();
        player.Hleath.CanbeAttacked = true;
        Debug.Log("OUT");
    }

    public override void Update()
    {
      //  player.Setvelocity(player.rb.velocity.x, current_Y);

        if (player.input.Attack)
        {
            TriggerCalled = true;
        }
        if (TriggerCalled)
            player.stateMachine.ChangeState(player.IdleState);
        base.Update();
    }
}

