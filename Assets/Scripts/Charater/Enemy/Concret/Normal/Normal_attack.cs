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
        Debug.Log("ININ");
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
   }

    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
        {
            demo.StateMachine.ChangeState(demo.searchingstate);
        }
        enemyBase.FacingPlayer();
    }
}
