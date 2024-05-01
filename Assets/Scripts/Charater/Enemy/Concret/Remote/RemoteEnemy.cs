using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteEnemy : NormalEnemy
{
   
    public GameObject shoot;
    public GameObject standard;

    public ShootState hootState;
    public override void Awake()
    {
        base.Awake();
        searchingForState = new SearchingForState(StateMachine, this, "Search",this);
        fouc = new Fouc(StateMachine, this, "fouc");
        hootState = new ShootState(StateMachine, this, "Shoot", this,this);
    }
    private void Start()
    {
        StateMachine.Initialize(searchingForState);
    }
    public override void Update()
    {

    
        base.Update();
    }
}

