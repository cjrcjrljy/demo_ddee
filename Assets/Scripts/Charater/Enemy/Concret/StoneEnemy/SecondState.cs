using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondState : EnemyState
{
    public int NorTime;
    public StoneEnemy stoneEnemy;
    public SecondState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
        NorTime = 3;
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
    }
}
