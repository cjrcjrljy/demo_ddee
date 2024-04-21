using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class EnemyStateMahine 
{
    public EnemyState CurrrentState {  get; private set; }
    public void Initialize(EnemyState _enemyState)
    {
        CurrrentState = _enemyState;
        CurrrentState.Enter();
    }
    public void ChangeState(EnemyState state)
    {
        CurrrentState.Exit();
        CurrrentState = state;
        CurrrentState.Enter();
    }
}
