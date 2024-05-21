using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public CrazyState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
    }
  
    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
        if ((TriggerCalled) )
        {
            stateMahine.ChangeState(stoneEnemy.secondState);
        }
    }
    public override void Exit()
    {
        base.Exit();
    }

}
