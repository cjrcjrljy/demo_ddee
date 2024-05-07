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
    public float ApearFlow;
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
        
    }
    public void TakeLight()
    {
        float xx=Random.Range(player.transform.position.x-ApearFlow,player.transform.position.x+ApearFlow);
        Vector3 appear = new Vector3(xx, CheckGro.transform.position.y);
        poolmanager.Release(FallingLight, appear);
    }
}
