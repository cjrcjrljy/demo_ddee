using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSkill : EnemyState
{
    public Horent horent;
    public BigSkill(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
    }

    public override void Enter()
    {
        base.Enter();
        horent.rb.gravityScale = 0;
        horent.Setvelocity(horent.Jump_x * horent.Facingdir, horent.Jump_y);
        horent.EffectAni.gameObject.SetActive(true);
     
    }

    public override void Exit()
    {
        horent.rb.gravityScale = 1f;
        
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if(!horent.EffectAni.isActiveAndEnabled)
        {
            stateMahine.ChangeState(horent.horfallstate);
        }
    }
}
