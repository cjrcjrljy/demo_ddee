using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorJumpAttack : JumpAttackState
{
    public string StateName;
    public HorJumpAttack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent, string stateName) : base(stateMahine, enemy, animatorName, horent)
    {
        StateName = stateName;
    }

    public override void Enter()
    {
       
        base.Enter();
        Debug.Log("inin");
        horent.animator.SetBool(StateName, true);
    }

    public override void Exit()
    {
        base.Exit();
        horent.animator.SetBool(StateName, false);
      
    }

    public override void Update()
    {
        base.Update();
     
        if (horent.IsGrounded)
        {
          
            stateMahine.ChangeState(horent.fitstState);
        }
    }
}
