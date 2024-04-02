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
        if (Input.Attack)
        {
            StateMachine.ChangeState(player.AttackState);
        }
        player.Facingontroller();
        if (Input.Move)
            StateMachine.ChangeState(player.moveState);
    }
}
