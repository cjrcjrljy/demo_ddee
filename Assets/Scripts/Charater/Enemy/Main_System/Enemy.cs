using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Enity
{
    public GameObject Target;
    public Player player;
    public EnemyStateMahine StateMachine;
    public bool trigger;
    public override void Awake()
    {
        base.Awake();
        Target = GameObject.Find("Player");
        player = Target.GetComponent<Player>();
        animator = GetComponentInChildren<Animator>();
        trigger = false;
        StateMachine =new EnemyStateMahine();
    }
    public void Update()
    {
        FacingPlayer();
        StateMachine.CurrrentState.Update();
    }
    public void FacingPlayer()
    {
        if (Target.transform.position.x < transform.position.x)
        {
            if (!FacingRight)
                Filp();
        }
        else
            if (FacingRight)
            Filp();
    }
}
