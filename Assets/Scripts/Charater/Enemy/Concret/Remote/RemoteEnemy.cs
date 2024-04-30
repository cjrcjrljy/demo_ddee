using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteEnemy : Enemy
{
    public SearchingForState searchingForState;
    public GameObject shoot;
    public GameObject Checkwall;
    public LayerMask Wall;
    public float checkwalldis;
    public bool iswall
    {
        get
        {
            return Physics2D.Raycast(Checkwall.transform.position, Vector2.right, Facingdir * checkwalldis, Wall);
        }
    }
    public GameObject standard;

    public ShootState hootState;
    public override void Awake()
    {
        base.Awake();
        searchingForState = new SearchingForState(StateMachine, this, "Search");
        fouc = new Fouc(StateMachine, this, "fouc");
        hootState = new ShootState(StateMachine, this, "Shoot", this);
    }
    private void Start()
    {
        StateMachine.Initialize(searchingForState);
    }
    public override void Update()
    {
        Debug.Log(IsFindPlayer_air);
     if(Input.GetKeyDown(KeyCode.P))
        {
            StateMachine.ChangeState(hootState);
        }
        if (iswall)
        {
            Filp();
        }
        base.Update();
    }
}

