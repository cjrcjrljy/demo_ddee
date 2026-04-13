using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMahine : MonoBehaviour
{
    public EnemyState CurrrentState;
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
