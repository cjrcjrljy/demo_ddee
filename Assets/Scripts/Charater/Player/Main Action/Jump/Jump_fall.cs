using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_fall : AircanmoveState
{
    public Jump_fall(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }
    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        if (player.IsGrounded)
            StateMachine.ChangeState(player.jump_Land);
    }
    public override void Exit()
    {
        base.Exit();
    }
}
