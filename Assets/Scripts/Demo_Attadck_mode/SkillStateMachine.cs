using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillStateMachine
{
    public SkillState State;
    public Stack<SkillState> StateStack;
    public SkillStateMachine()
    {
        StateStack = new Stack<SkillState>();
    }
    public void AddSKill(SkillState skillState)
    {
        StateStack.Push(skillState);
        if(StateStack.Count > 0 ) 
            this.State.Exit();
        this.State = StateStack.Peek();
        this.State.Enter(); ;
    }
    public void Initialize(SkillState state)
    {
        this.State = state;
        AddSKill(state);
    }
    //public void ChangeState(SkillState state)
    //{
    //    this.State.Exit();
    //    this.State = state;
    //    this.State.Enter();
    //}
    public void SwitchSkill()
    {
        this.State.Exit();
        if(StateStack.Count>1)
        {
            StateStack.Pop();
        }
        this.State= StateStack.Peek();
        this.State.Enter();
    }
}
