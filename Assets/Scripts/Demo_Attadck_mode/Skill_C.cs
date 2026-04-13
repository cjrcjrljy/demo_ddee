using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill_C : SkillState
{
    public Skill_C(string _animatorname, SkillStateMachine stateMachine, Player player) : base(_animatorname, stateMachine, player)
    {
    }
  
    public override void Enter()
    {
        text = player.text_C;
        text.text = "CCC";
        player.uI_3.animator.enabled = true;
        player.uI_3.animator.SetBool("change", false);
        player.uI_3.animator.SetBool("normal", true);

        base.Enter();
    }
    public override void UPdate()
    {
        base.UPdate();
        if (player.change_BIG && player.input.Switch&&ChangeTime<0)
        {
            player._A.currrec = 0;
            player.text_A.text = "FFF";
            player.text_B.text = "GGG";
            player.text_C.text = "UUU";
            player.init(player.text_A,player.uI_1);
            player.init(player.text_B, player.uI_2);
            player.init(player.text_C, player.uI_3);
            player.BIg_after(player.ready);
        }
        if (player.input.Realse)
        {
            stateMachine.ChangeState(player._B);
            Change_ani(player.uI_3);
        }
    }
    public override void Exit()
    {
        //player.uI_3.animator.SetBool("change", true);
        //player.uI_3.animator.SetBool("normal", false);
        base.Exit();
    }
}

