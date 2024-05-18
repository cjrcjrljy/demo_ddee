using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitstate : PlayerState 
{
    public float hitdis=7f;
    public Hitstate(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Time.timeScale = 0.5f;
        player.Hleath.CanbeAttacked = false;
        player.Setvelocity(hitdis * player.Facingdir*-1, 4f);
    }

    public override void Exit()
    {
        player.IsHitted = false;
        base.Exit();
        Time.timeScale = 1;
        player.Hleath.CanbeAttacked = true;
    }

    public override void Update()
    {
        if (TriggerCalled)
        {
            StateMachine.ChangeState(player.IdleState);
        }
        base.Update();
        
    }
}
