using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemy : Enemy
{
    public Vector3 LeftUp;
    public Vector3 RightDown;
    public AIrSearchingState searchingState;
    public override void Awake()
    {
        base.Awake();
        searchingState = new AIrSearchingState(StateMachine, this, "Search", this);
        StateMachine.Initialize(searchingState);
    }

    public override void Update()
    {
        base.Update();
    }
}
