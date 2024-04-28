using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootState : EnemyState
{
    public RemoteEnemy remote;
    public ShootState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, RemoteEnemy remote) : base(stateMahine, enemy, animatorName)
    {
        this.remote = remote;
    }

    public override void Enter()
    {
        base.Enter();
        enemyBase.Setvelocity(0, 0);
        poolmanager.Release(remote.shoot,remote.standard.transform.position);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
            stateMahine.ChangeState(remote.searchingForState);
    }
}
