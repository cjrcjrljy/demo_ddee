using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Enity
{
    public EnemyStateMahine StateMachine;
    public override void Awake()
    {
        base.Awake();
        StateMachine=new EnemyStateMahine();
    }
    public void Update()
    {
       
        StateMachine.CurrrentState.Update();
    }
}
