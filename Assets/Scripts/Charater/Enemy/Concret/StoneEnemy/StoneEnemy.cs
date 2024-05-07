using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneEnemy : Enemy
{
    public GameObject FallingLight;
    public GameObject CheckGro;
    public StoneIdleState stoneIdle;
    public StoneTowardState stoneTowardState;
    public IsreadyToattack isready;
    public RemoteFalState remoteFal;
    public Stone_firstStage stone_FirstStage;
    public float ApearFlow;
    public override void Awake()
    {
        base.Awake();
        isready=GetComponentInChildren<IsreadyToattack>();
        stoneIdle = new StoneIdleState(StateMachine, this, "Attack", this);
        remoteFal = new RemoteFalState(StateMachine, this, "Falling", this);
        stoneTowardState = new StoneTowardState(StateMachine, this, "Searching", this);
        stone_FirstStage = new Stone_firstStage(StateMachine, this, "First", this);
    }
    private void OnEnable()
    {
        StateMachine.Initialize(stone_FirstStage);
    }
    public override void Update()
    {
        base.Update();
        
    }
    /// <summary>
    /// ²úÉúÂäÀ×
    /// </summary>
    public void TakeLight()
    {
        float xx=Random.Range(player.transform.position.x-ApearFlow,player.transform.position.x+ApearFlow);
        Vector3 appear = new Vector3(xx, CheckGro.transform.position.y);
        poolmanager.Release(FallingLight, appear);
    }
}
