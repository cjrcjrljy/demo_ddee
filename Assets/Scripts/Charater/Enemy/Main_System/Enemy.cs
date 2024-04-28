using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 每个都会有fouc，需要每次new一个
/// </summary>
public class Enemy : Enity
{
    [Header("enemy")]
    public GameObject Target;
    public Player player;
    public EnemyStateMahine StateMachine;
    public bool trigger;
    public Fouc fouc;
    public FindPlayer findPlayer;
    public float Movespeed;
    public bool IsFindPlayer => findPlayer.Findpp;
    [Header("Attack")]
    public EnemyAttack[] enemyAttacks;
    public override void Awake()
    {
        base.Awake();
        findPlayer = GetComponentInChildren<FindPlayer>();
        Target = GameObject.Find("Player");
        player = Target.GetComponent<Player>();
     
        animator = GetComponentInChildren<Animator>();
        trigger = false;
        StateMachine =new EnemyStateMahine();
    }
    public virtual  void Update()
    {
      
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
