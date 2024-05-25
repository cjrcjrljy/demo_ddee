using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitstState : EnemyState
{
    Horent horent;
    public FitstState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Horent horent) : base(stateMahine, enemy, animatorName)
    {
        this.horent = horent;
    }
    public override void Enter()
    {
        base.Enter();
        horent.FacingPlayer();
        horent.Setvelocity(0, 0);
        SwitchAttack();
    }
    public override void Update()
    {
        base.Update();
        horent.FacingPlayer();
    }

    public override void Exit()
    {
        base.Exit();
    }
    public void SwitchAttack()
    {
            int atta = Random.Range(0, 10);
            if (atta <= 3)
                stateMahine.ChangeState(horent.attacK_Horstate);
            else if (atta > 3 && atta <= 7)
                stateMahine.ChangeState(horent.horJump);
            else
                stateMahine.ChangeState(horent.bigSkill);
    
    }
}


