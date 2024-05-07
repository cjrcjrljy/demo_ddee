using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteFalState : Stone_firstStage
{
    public RemoteFalState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName, stoneEnemy)
    {
    }

    public override void Enter()
    {
        base.Enter();
        stoneEnemy.TakeLight();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
