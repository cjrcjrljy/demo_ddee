using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Normal_attack : EnemyState
{
    public Enemy_Demo demo;
    public Normal_attack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Enemy_Demo demo) : base(stateMahine, enemy, animatorName)
    {
        this.demo = demo;
    }

    public override void Enter()
    {
        demo.StartCoroutine(WaitforBack());
        enemyBase.Setvelocity(enemyBase.Movespeed * 3.2f * enemyBase.Facingdir, enemyBase.rb.velocity.y);
        Debug.Log("ININ");
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
      demo.StopCoroutine(WaitforBack());
    }

    public override void Update()
    {
        base.Update();
        enemyBase.FacingPlayer();
    }
    IEnumerator WaitforBack()
    {
        yield return demo.Backtime;
        demo.StateMachine.ChangeState(demo.searchingstate);
    }
}
