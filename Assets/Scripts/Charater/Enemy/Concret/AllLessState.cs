using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AllLessState : EnemyState
{
    public Enemy_Demo demo;
    public AllLessState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName
        , Enemy_Demo demo) : base(stateMahine, enemy, animatorName)
    {
        this.demo = demo;
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
        if (enemyBase.IsHitted)
        {
            stateMahine.ChangeState(demo.hittedstate);
        }
        base.Update();
    }
}
