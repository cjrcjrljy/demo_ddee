using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.AxisState;

public class AircanmoveState : PlayerState
{
    public AircanmoveState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }
    public override void Enter()
    {
        player.Collider.sharedMaterial = player.Zero;
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        player.Facingontroller();
        if (Input.Attack)
        {
            StateMachine.ChangeState(player.AttackState);
        }
        player.Setvelocity(player.input.AxisX *player.Movespeed/1.1f, player.rb.velocity.y);
    }
    public override void Exit()
    {
        player.Collider.sharedMaterial = player.ori;
        base.Exit();
    }
}
