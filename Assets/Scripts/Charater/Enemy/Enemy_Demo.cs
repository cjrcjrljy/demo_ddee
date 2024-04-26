using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo : Enemy
{
    public GameObject Checkwall;
    public LayerMask Wall;
    public float checkwalldis;
    public WaitForSeconds Backtime;
    public Normal_attack normalattackstate;
    public float bbacktime;
    public bool iswall
    {
        get
        {
            return Physics2D.Raycast(Checkwall.transform.position, Vector2.right, Facingdir * checkwalldis, Wall);
        }
    }
    public SearchingForState searchingstate;
    public override void Awake()
    {
        base.Awake();
        normalattackstate = new Normal_attack(StateMachine, this, "Attack", this);
        Backtime = new WaitForSeconds(bbacktime);
        fouc = new Fouc(StateMachine, this, "Focus");
        searchingstate = new SearchingForState(StateMachine, this, "Search");
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
