using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill_B : SkillState
{
    public Skill_B(string _animatorname, SkillStateMachine stateMachine, Player player) : base(_animatorname, stateMachine, player)
    {
    }
  
    public override void Enter()
    {
        text = player.text_B;
        base.Enter();
        text.text = "BBB";
        player.uI_2.animator.enabled = true;
        player.uI_2.animator.SetBool("change", false);
        player.uI_2.animator.SetBool("normal", true);

    }
    public override void UPdate()
    {
        if (player.change_BIG && Input.GetKeyDown(KeyCode.K)&&ChangeTime<0)
            stateMachine.ChangeState(player._C);
        if (Input.GetKey(KeyCode.H) && ChangeTime < 0)
        {
            stateMachine.ChangeState(player._A);
            Change_ani(player.uI_2);
        }
        base.UPdate();
    }
    public override void Exit()
    {
        //player.uI_2.animator.SetBool("change", true);
        //player.uI_2.animator.SetBool("normal", false);
        base.Exit();
    }
}
