using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : PlayerState
{
    public JumpState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }
    public override void Enter()
    {
        base.Enter();
        player.Setvelocity(player.rb.velocity.x, player.jumpheigh);
    }
    public override void Update()
    {
        base.Update();
        if (player.input.Attack)
            StateMachine.ChangeState(player.IdleState);
    }
}
