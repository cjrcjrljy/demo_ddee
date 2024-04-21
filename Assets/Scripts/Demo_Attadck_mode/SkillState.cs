using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillState
{
    public Text text;
    public Player player;
    public float ChangeTime;
    public float duration=.75f;
    public SkillStateMachine stateMachine;
    public float maxrec = 30;
    public float currrec = 0;
    public SkillState( string _animatorname, SkillStateMachine stateMachine, 
        Player player)
    {
        this.stateMachine = stateMachine;
        this.player = player;
    }
    public virtual void Enter()
    {
        ChangeTime = duration;

    }
    public virtual void UPdate()
    {
        ChangeTime-= Time.deltaTime;
    }
    public virtual void Exit() 
    {
        player.change_Skill=false;

    }
    /// <summary>
    /// ÇÐ»»²ÛÎ»µÄ¶¯»­
    /// </summary>
    /// <param name="uI_"></param>
    public void Change_ani(UI_Caowei uI_)
    {
        uI_.animator.SetBool("change", true);
        uI_.animator.SetBool("normal", false);
    }
}