using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttackState : EnemyState
{
    public Horent horent;
    public JumpAttackState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
    }

    public override void Enter()
    {
        horent.rb.gravityScale = 0;
        horent.Setvelocity(horent.Jump_x * horent.Facingdir, horent.Jump_y);
        base.Enter();
        Debug.Log("jn");
       
    }

    public override void Exit()
    {
        base.Exit();
        horent.rb.gravityScale = 1f;
    }

    public override void Update()
    {
        base.Update();
       

    }   
}
