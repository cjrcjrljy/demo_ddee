using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitstState : EnemyState
{
    Horent horent;
    public FitstState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
    }
    public override void Enter()
    {
        base.Enter();
        horent.Setvelocity(0, 0);
    }
    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.J))
        {
            stateMahine.ChangeState(horent.attacK_Horstate);
        }
        if(Input.GetKeyDown(KeyCode.F)) {
            stateMahine.ChangeState(horent.bigSkill);
        }
        if (Input.GetKeyDown(KeyCode.K))
            stateMahine.ChangeState(horent.horJump);
        if (horent. IsGrounded)
        {
            horent.animator.SetBool("Isgroud", true);
        }
        else
        {
            horent.animator.SetBool("Isgroud", false);
            horent.animator.Play("jumpFall");
        }
        horent.FacingPlayer();
    }

    public override void Exit()
    {
        base.Exit();
    }
}


