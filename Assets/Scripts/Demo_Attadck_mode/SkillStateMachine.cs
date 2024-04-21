using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillStateMachine
{
    public SkillState State;
    public void Initialize(SkillState state)
    {
        this.State = state;
        this.State.Enter();
    }
    public void ChangeState(SkillState state)
    {
        this.State.Exit();
        this.State = state;
        this.State.Enter();
    }
}
