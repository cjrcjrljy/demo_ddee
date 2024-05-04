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
    public FindPlayer findPlayer;
    public bool IsFindPlayer_grou => findPlayer.Findp_ground;
    public bool IsFindPlayer_air => findPlayer.FindP_Air;
    public bool iswall
    {
        get
        {
            return Physics2D.Raycast(Checkwall.transform.position, Vector2.right, Facingdir * checkwalldis, Wall);
        }
    }
    public override void Awake()
    {
        findPlayer = GetComponentInChildren<FindPlayer>();
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
