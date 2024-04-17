using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DashState : PlayerState
{
    
    public int Dashspeed = 3;
    public int facdir = 1;
    public float current_Y;
    public float current_gra;
    public DashState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        player.Collider.isTrigger=true;
        player.Hleath.CanbeAttacked = false;
        base.Enter();
        float dir=player.Facingdir;
        float dir_y = player.input.AxisY;
        if(player.input.AxisY != 0) {
            dir=player.input.AxisX;
        }
        player.Setvelocity(dir*9, dir_y*5);
        current_gra = player.rb.gravityScale;
        player.rb.gravityScale=0;
        current_Y=player.rb.velocity.y;
    }

    public override void Exit()
    {
        base.Exit();
        player.Collider.isTrigger=false;
        player.rb.gravityScale = current_gra;
        player.Hleath.CanbeAttacked = true;
    }

    public override void Update()
    {
      //  player.Setvelocity(player.rb.velocity.x, current_Y);

        if (player.input.Attack)//仅供方便没有动画是的demo，后会删除
        {
            TriggerCalled = true;
        }
        if (TriggerCalled)
            player.stateMachine.ChangeState(player.IdleState);
        base.Update();
    }
}

