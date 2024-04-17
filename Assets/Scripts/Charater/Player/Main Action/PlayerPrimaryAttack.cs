using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimaryAttack : PlayerState
{
    public int ComboCounter=0;
    public float comboWindow=2;
    public float LastTimeAttacked;
    public float Gravity;
    public PlayerPrimaryAttack(Player _player, PlayerStateMachine _statemachine, string _animator, PlayerInput input) : base(_player, _statemachine, _animator, input)
    {
    }

    public override void Enter()
    {
        Gravity = player.rb.gravityScale;
        player.Setvelocity(player.rb.velocity.x, player.rb.velocity.y/1.2f);
        if (Time.time > LastTimeAttacked + comboWindow)
            ComboCounter = 0;
        player.change_Skill = true;
       
        player.animator.SetInteger("ComboCounter", ComboCounter);
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        player.rb.gravityScale = Gravity;
        player.change_Skill = false;
        LastTimeAttacked=Time.time; 
        ComboCounter++;
        if (ComboCounter > 1 )
            ComboCounter = 0;
        player.animator.SetInteger("ComboCounter", ComboCounter);
    }

    public override void Update()
    {
        if (TriggerCalled)
            StateMachine.ChangeState(player.IdleState);
        base.Update();
    }
    public void recc(float rec)
    {
        if (player._A.currrec < player._A.maxrec)
            player.StartCoroutine(player._A.Hit_andre(rec));
    }
}
