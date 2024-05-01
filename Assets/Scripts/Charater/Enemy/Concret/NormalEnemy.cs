using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy :Enemy
{
    public GameObject Checkwall;
    public LayerMask Wall;
    public float checkwalldis;
    public float HittedDis;
    public HittedState hittedstate;
    public SearchingForState searchingForState;
    public bool iswall
    {
        get
        {
            return Physics2D.Raycast(Checkwall.transform.position, Vector2.right, Facingdir * checkwalldis, Wall);
        }
    }
    public override void Awake()
    {
        base.Awake();
        hittedstate = new HittedState(StateMachine, this, "Hitted", this);
    }
    public override void Update()
    {
        if (iswall)
        {
            Filp();
        }
        base.Update();
    }

}
