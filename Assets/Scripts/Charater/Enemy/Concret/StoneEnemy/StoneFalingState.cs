using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFalingState :EnemyState
{
    public StoneEnemy stoneEnemy;
    public StoneFalingState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
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
        base.Update();
        if (TriggerCalled)
            stateMahine.ChangeState(stoneEnemy.stone_FirstStage);
    }
}
