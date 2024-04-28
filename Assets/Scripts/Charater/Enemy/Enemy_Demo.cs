using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo : Enemy
{

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
    public WaitForSeconds Backtime;
    public Normal_attack normalattackstate;
    public HittedState hittedstate;
    public float bbacktime;

    public float HittedDis;

    public SearchingForState searchingstate;
    public override void Awake()
    {
        base.Awake();
        hittedstate = new HittedState(StateMachine, this, "Hitted", this);
        normalattackstate = new Normal_attack(StateMachine, this, "Attack", this);
        Backtime = new WaitForSeconds(bbacktime);
        fouc = new Fouc(StateMachine, this, "Focus");
        searchingstate = new SearchingForState(StateMachine, this, "Ilde");
        StateMachine.Initialize(searchingstate);
    }

    public override void Update()
    {
        base.Update();
        if (iswall)
        {
            Filp();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Checkwall.transform.position, new Vector3(Checkwall.transform.position.x + checkwalldis * Facingdir,
            Checkwall.transform.position.y));
    }
}
