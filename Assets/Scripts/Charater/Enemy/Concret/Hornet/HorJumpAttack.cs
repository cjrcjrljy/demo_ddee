using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorJumpAttack :EnemyState
{
    
    public Horent horent;
    public HorJumpAttack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
      
    }

    public override void Enter()
    {
        StateTimer=0.5f;
        horent.Setvelocity(horent.Jump_x * horent.Facingdir, 1.7f*horent.Jump_y);
        horent.animator.SetBool("JumpState", false);
        base.Enter();
       
    }

    public override void Exit()
    {
      horent.rb.gravityScale = 1.0f;
        base.Exit();
      
        horent.Setvelocity(0, 0);
    }

    public override void Update()
    {
        base.Update();
        if (StateTimer < 0)
            if (horent.IsGrounded)
                stateMahine.ChangeState(horent.gap);
   
    }
}
