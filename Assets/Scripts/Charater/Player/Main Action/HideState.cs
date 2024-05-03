using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideState : PlayerState
{
    public HideState(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.Hleath.CanbeAttacked = false;
        float XXinput = player.input.axes.x;
        int facing = -1 * player.Facingdir;
        if (Mathf.Abs(XXinput) <= Mathf.Abs( Mathf.Epsilon))
            player.Setvelocity(facing * player.Movespeed*1.2f, 0);
        else
            player.Setvelocity(XXinput*player.Movespeed*1.5f, 0);
    }

    public override void Exit()
    {
        base.Exit();
        player.Hleath.CanbeAttacked=true;
    }
    
    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
            StateMachine.ChangeState(player.IdleState);
    }
}
