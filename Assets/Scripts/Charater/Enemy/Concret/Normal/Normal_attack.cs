using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// ¼Ì³ÐµÄalllessÀà
/// </summary>
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
        if (NormalEnemy.IsHitted)
            stateMahine.ChangeState(NormalEnemy.hittedstate);
        base.Update();
        enemyBase.FacingPlayer();
    }
}
