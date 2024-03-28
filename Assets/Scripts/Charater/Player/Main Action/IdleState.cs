using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : PlayerState
{
    public IdleState(Player _player, PlayerStateMachine _statemachine, string _animator) : base(_player, _statemachine, _animator)
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
        player.Facingontroller();
        if (Xinput != 0)
            StateMachine.ChangeState(player.moveState);
    }
}
