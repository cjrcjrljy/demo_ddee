using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Normal_attack :AllLessState
{
    public Normal_attack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, NormalEnemy normalEnemy) : base(stateMahine, enemy, animatorName, normalEnemy)
    {
    }

    public override void Enter()
    {
    
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
        NormalEnemy.Setvelocity(0, 0);
   }

    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
        {
            NormalEnemy.StateMachine.ChangeState(NormalEnemy.searchingForState);
        }
        enemyBase.FacingPlayer();
    }
}
