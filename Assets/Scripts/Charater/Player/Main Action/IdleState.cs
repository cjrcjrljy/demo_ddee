using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : PlayerState
{
    public IdleState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
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
        if (!player.IsGrounded && player.rb.velocity.y < 0)
            StateMachine.ChangeState(player.jump_Fall);
        if (Input.Attack)
        {
            StateMachine.ChangeState(player.AttackState);
        }
        player.Facingontroller();
        if (Input.Move&&player.IsGrounded)
            StateMachine.ChangeState(player.moveState);
    }
}
