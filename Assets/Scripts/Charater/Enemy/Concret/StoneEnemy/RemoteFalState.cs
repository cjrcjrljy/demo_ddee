using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteFalState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public RemoteFalState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
    }

    public override void Enter()
    {
        base.Enter();
      stoneEnemy.StartCoroutine(ShootFal(stoneEnemy.Fallingmuch));
    }

    public override void Exit()
    {
        base.Exit();
        stoneEnemy.StopAllCoroutines();
    }

    public override void Update()
    {
        base.Update();
        if (TriggerCalled)
            stateMahine.ChangeState(stoneEnemy.stone_FirstStage);
    }
    IEnumerator ShootFal(int much)
    {
        for(int i = 0;i<much;i++)
        {
            stoneEnemy.TakeLight();
            yield return stoneEnemy.waitgap_fal;
        }
    }
}
