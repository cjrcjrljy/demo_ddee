using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Normal_attack :AllLessState
{
    public Normal_attack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Enemy_Demo demo) : base(stateMahine, enemy, animatorName, demo)
    {
    }

    public override void Enter()
    {
    
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
        demo.Setvelocity(0, 0);
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
