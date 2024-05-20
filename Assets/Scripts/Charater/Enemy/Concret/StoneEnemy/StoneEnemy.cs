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
    public SecondState secondState;
    public Stone_firstStage stone_FirstStage;
    public SecondReadyState secondReadyState;
    public float ApearFlow;
    public int Fallingmuch;
    public WaitForSeconds waitgap_fal;
    public bool IsSecond;
    public GameObject Boom;   
    public float gapTime;
    public override void Awake()
    {
        IsSecond = false;
        base.Awake();
        waitgap_fal = new WaitForSeconds(gapTime);
        isready=GetComponentInChildren<IsreadyToattack>();
        stoneIdle = new StoneIdleState(StateMachine, this, "Attack", this);
        remoteFal = new RemoteFalState(StateMachine, this, "Falling", this);
        stoneTowardState = new StoneTowardState(StateMachine, this, "Searching", this);
        stone_FirstStage = new Stone_firstStage(StateMachine, this, "First", this);
        secondState=new SecondState(StateMachine, this,"Second",this);
        secondReadyState = new SecondReadyState(StateMachine, this, "Ready", this);
    }
    private void OnEnable()
    {
        StateMachine.Initialize(stoneIdle);
      
    }
    public override void Update()
    {
        base.Update();
        if (IsHitted)
        {
           
            IsHitted = false;
        }
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
