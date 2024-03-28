using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_A : SkillState
{
    string[] outp = { "AAA", "AAA_!", "A" };

    public Skill_A(string _animatorname, SkillStateMachine stateMachine, Player player) : base(_animatorname, stateMachine, player)
    {
    }
    public IEnumerator Hit_andre(float rec)
    {
        player.Hleath.Recevery(rec);
        currrec += rec;
        yield return new WaitForSeconds(1);
    }
    public override void Enter()
    {
      
        text = player.text_A;
        base.Enter();
                               

     
        player.uI_1.animator.enabled = true;
        player.uI_1.animator.SetBool("change", false);
        player.uI_1.animator.SetBool("normal", true);

    }
    public override void UPdate()
    {
        text.text = outp[player.AttackState.ComboCounter];
        if (player.change_BIG && Input.GetKeyDown(KeyCode.K)&&ChangeTime<0)
            stateMachine.ChangeState(player._B);
        if (Input.GetKey(KeyCode.H)&&ChangeTime<0)
        {
            stateMachine.ChangeState(player.ready);
            Change_ani(player.uI_1);
        }
        base.UPdate();
    }
    public override void Exit()
    {
        base.Exit();
        //player.uI_1.animator.SetBool("change", true);
        //player.uI_1.animator.SetBool("normal", false);
      
    }
   
}

