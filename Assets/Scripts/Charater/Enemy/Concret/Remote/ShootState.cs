using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootState :AllLessState
{
    public RemoteEnemy remote;
    public ShootState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, NormalEnemy normalEnemy, RemoteEnemy remote) : base(stateMahine, enemy, animatorName, normalEnemy)
    {
        this.remote = remote;
    }

    public override void Enter()
    {
        base.Enter();
        enemyBase.Setvelocity(0, 0);
       // poolmanager.Release(remote.shoot,remote.standard.transform.position);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        enemyBase.FacingPlayer();
        if (remote.IsHitted)
            stateMahine.ChangeState(remote.hittedstate);
        if (TriggerCalled)
            stateMahine.ChangeState(remote.searchingForState);
    }
}
