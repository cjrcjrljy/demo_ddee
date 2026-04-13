using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill_B : SkillState
{
    public Skill_B(string _animatorname, SkillStateMachine stateMachine, Player player) : base(_animatorname, stateMachine, player)
    {
    }
    public int dashspeed = 5;
    public override void Enter()
    {
        text = player.text_B;
        dashspeed = 5;
        base.Enter();
        text.text = "BBB";
        player.uI_2.animator.enabled = true;
        player.uI_2.animator.SetBool("change", false);
        player.uI_2.animator.SetBool("normal", true);

    }
    public override void UPdate()
    {
        if (player.change_BIG && player.input.Switch && ChangeTime<0)
            stateMachine.ChangeState(player._C);
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.stateMachine.ChangeState(player.dashState);
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
