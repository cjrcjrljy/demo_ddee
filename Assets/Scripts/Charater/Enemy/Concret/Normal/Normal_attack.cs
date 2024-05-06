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
        NormalEnemy.Hleath.Fx.sr.material = NormalEnemy.Hleath.Fx.ReadyAttack;
    }

    public override void Exit()
    {
        NormalEnemy.Hleath.Fx.sr.material = NormalEnemy.Hleath.Fx.originalMat;
        NormalEnemy.Setvelocity(0, 0);
        base.Exit();
   }

    public override void Update()
    {
        if (NormalEnemy.IsHitted)
            stateMahine.ChangeState(NormalEnemy.hittedstate);
        if (TriggerCalled)
            stateMahine.ChangeState(NormalEnemy.searchingForState);
        base.Update();
        enemyBase.FacingPlayer();
    }
}
