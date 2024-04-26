using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal_ani :Ene_ani
{
    public Enemy_Demo enemyBase;
    public override void Awake()
    {
        base.Awake();
        enemyBase=GetComponentInParent<Enemy_Demo>();
    }
    public void DashSet()
    {
        enemyBase.Setvelocity(enemyBase.Movespeed * 3.2f * enemyBase.Facingdir, enemyBase.rb.velocity.y);
    }
    public void TriggerOut()
    {
        enemyBase.StateMachine.CurrrentState.TriggerCalled = true;
    }
}