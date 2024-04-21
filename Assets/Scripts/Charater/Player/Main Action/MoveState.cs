using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : PlayerState
{
    public float speedmove;

    public MoveState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        base.Enter();
      
        speedmove = player.Movespeed;
    }
    public override void Update()
    {
        if (Input.Attack)
        {
            StateMachine.ChangeState(player.AttackState);
        }
        base.Update();
        player.Facingontroller();
        player.Setvelocity(player.input.AxisX * speedmove, player.rb.velocity.y);
        if (!player.IsGrounded && player.rb.velocity.y < 0)
            StateMachine.ChangeState(player.jump_Fall);
        if (Mathf.Abs(player.input.AxisX) <= 0.01f)
            StateMachine.ChangeState(player.IdleState);
    }
    public override void Exit()
    {
        player.rb.velocity=new Vector2(0,player.rb.velocity.y);
        base.Exit();
    }
}
