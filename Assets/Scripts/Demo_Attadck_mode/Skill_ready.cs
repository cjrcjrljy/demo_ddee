using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_ready : SkillState
{
    public Skill_ready(string _animatorname, SkillStateMachine stateMachine, Player player) : base(_animatorname, stateMachine, player)
    {
    }
    public override void Enter()
    {
       
       
        base.Enter();
    }
    public override void UPdate()
    {
        base.UPdate();
        if (player.change_Skill)
            stateMachine.ChangeState(player._A);
    }
}
