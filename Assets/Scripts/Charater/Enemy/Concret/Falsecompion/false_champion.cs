using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class false_champion : Enemy 
{
    public False_idle idlestate;
    public False_move movestate;
    public override void Awake()
    {
        base.Awake();
        movestate = new False_move(StateMachine, this, "Move");
        idlestate = new False_idle(StateMachine, this, "Idle");
        StateMachine.Initialize(idlestate);
    }
}
