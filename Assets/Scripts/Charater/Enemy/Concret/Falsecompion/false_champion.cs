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
        fouc = new Fouc(this.StateMachine, this, "Focus");
        movestate = new False_move(StateMachine, this, "Move", this);
        idlestate = new False_idle(StateMachine, this, "Idle",this);
        StateMachine.Initialize(idlestate);
    }
    public override void Update()
    {
     
        base.Update();
    }
}
