using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AllLessState : EnemyState
{
    public NormalEnemy NormalEnemy;
    public AllLessState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, NormalEnemy normalEnemy) : base(stateMahine, enemy, animatorName)
    {
        NormalEnemy = normalEnemy;
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
        if (NormalEnemy.IsHitted)
        {
            stateMahine.ChangeState(NormalEnemy.hittedstate);
        }
        base.Update();
    }
}
