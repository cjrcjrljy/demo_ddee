using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState CurrentState { get; private 
            set; }
    public void Initialize(PlayerState _StartState)
    {
        CurrentState = _StartState;
        CurrentState.Enter();
    }
    public void ChangeState(PlayerState _NewState)
    {
        CurrentState.Exit();
        CurrentState=_NewState;
        CurrentState.Enter();

    }
}