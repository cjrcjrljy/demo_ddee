using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class Stone_firstStage : EnemyState
{
    public StoneEnemy stoneEnemy;
    public bool CanEnterNorAttack;
    public bool CanEnterRemoteFal;


    public Stone_firstStage(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
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
        if (CanEnterNorAttack)
        {
            stateMahine.ChangeState(stoneEnemy.stoneIdle);
            CanEnterRemoteFal = false;
        }
        if(CanEnterRemoteFal)
        {
            stateMahine.ChangeState(stoneEnemy.remoteFal);
        }
        if (TriggerCalled)
            stateMahine.ChangeState(stoneEnemy.stone_FirstStage);
    }
}
