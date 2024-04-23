using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState :AircanmoveState
{
    public JumpState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }
    public override void Enter()
    {
        base.Enter();
        player.Setvelocity(player.input.AxisX, player.jumpheigh);

    }
    public override void Update()
    {
        base.Update();
        if (player.rb.velocity.y < -0.2f)
            StateMachine.ChangeState(player.jump_Fall);
    }
}
