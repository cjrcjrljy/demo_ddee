using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : PlayerState
{
    public float speedmove;
    public MoveState(Player _player, PlayerStateMachine _statemachine, string _animator) : base(_player, _statemachine, _animator)
    {

    }

    public override void Enter()
    {
        base.Enter();
        speedmove = player.Movespeed;
       
    }
    public override void Update()
    {
        base.Update();
        player.Facingontroller();
        player.rb.velocity = new Vector2(Xinput * speedmove, player.rb.velocity.y);
        if (Mathf.Abs(Xinput)<=0.01f)
            StateMachine.ChangeState(player.IdleState);
    }
    public override void Exit()
    {
        player.rb.velocity=new Vector2(0,player.rb.velocity.y);
        base.Exit();
    }
}
