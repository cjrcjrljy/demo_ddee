using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimaryAttack : PlayerState
{
    public int ComboCounter=0;
    public float comboWindow=2;
    public float LastTimeAttacked;
    public PlayerPrimaryAttack(Player _player, PlayerStateMachine _statemachine, string _animator) : base(_player, _statemachine, _animator)
    {
    }

    public override void Enter()
    {

        Debug.Log(player._A.currrec);
        if (Time.time > LastTimeAttacked + comboWindow)
            ComboCounter = 0;
        player.change_Skill = true;
        if (player.Hleath.currentHleath < player.Hleath.maxHleath)
            recc(10);
        player.animator.SetInteger("ComboCounter", ComboCounter);
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        player.change_Skill = false;
        LastTimeAttacked=Time.time; 
        ComboCounter++;
        if (ComboCounter > 1 )
            ComboCounter = 0;
        player.animator.SetInteger("ComboCounter", ComboCounter);
    }

    public override void Update()
    {
      
        player.rb.velocity = new Vector2(0, player.rb.velocity.y / 10);
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
