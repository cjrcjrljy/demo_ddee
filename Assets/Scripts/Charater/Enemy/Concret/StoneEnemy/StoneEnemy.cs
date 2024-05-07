using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneEnemy : Enemy
{
    public StoneIdleState stoneIdle;
    public StoneTowardState stoneTowardState;
    public IsreadyToattack isready;
    public GameObject FallingLight;
    public GameObject CheckGro;
    public override void Awake()
    {
        base.Awake();
        isready=GetComponentInChildren<IsreadyToattack>();
        stoneIdle = new StoneIdleState(StateMachine, this, "Attack", this);
        stoneTowardState = new StoneTowardState(StateMachine, this, "Searching", this);
    }
    private void OnEnable()
    {
        StateMachine.Initialize(stoneTowardState);
    }
    public override void Update()
    {
        base.Update();
        if(Input.GetKeyDown(KeyCode.X)) {
            TakeLight();
        }
    }
    public void TakeLight()
    {
        poolmanager.Release(FallingLight, CheckGro.transform.position);
    }
}
