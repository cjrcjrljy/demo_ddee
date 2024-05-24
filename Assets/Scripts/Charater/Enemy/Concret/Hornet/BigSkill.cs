using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSkill : JumpAttackState
{
    public string StateName;

    public BigSkill(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent,string statename) : base(stateMahine, enemy, animatorName, horent)
    {
        StateName = statename;
    }

    public override void Enter()
    {
        base.Enter();

        horent.EffectAni.gameObject.SetActive(true);
        enemyBase.animator.SetBool(StateName, true);
    }

    public override void Exit()
    {
        horent.rb.gravityScale = 1f;
        enemyBase.animator.SetBool(StateName, false);
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if(!horent.EffectAni.isActiveAndEnabled)
        {
            stateMahine.ChangeState(horent.fitstState);
        }
    }
}
