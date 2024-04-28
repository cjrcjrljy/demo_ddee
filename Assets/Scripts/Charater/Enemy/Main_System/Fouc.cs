using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fouc : EnemyState
{
    public Fouc(EnemyStateMahine stateMahine, Enemy enemy, string animatorName) : base(stateMahine, enemy, animatorName)
    {
    }

    public override void Enter()
    {
       
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
       
      if(enemyBase.TryGetComponent<Enemy_Demo>(out Enemy_Demo attack))
        {
            enemyBase.StateMachine.ChangeState(attack.normalattackstate);
                
         }
        if (enemyBase.TryGetComponent<RemoteEnemy>(out RemoteEnemy remoteEnemy))
            enemyBase.StateMachine.ChangeState(remoteEnemy.hootState);
        base.Update();
    }
}
