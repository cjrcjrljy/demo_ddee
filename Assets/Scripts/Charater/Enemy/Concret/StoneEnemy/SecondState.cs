using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public bool CanEnterNorAttack;

    public int ModeAttack;
    public int ModeUp = 0;
    public SecondState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
    }

    public override void Enter()
    {
        ModeAttack = 0;
        ModeUp = 5;
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
    public void AttackMode_Change()
    {

    }
    public void ChangeMode()
    {
        ModeAttack++;
        ModeAttack %= ModeUp;
        //if (ModeAttack == 0)
        //{
        //    other = true;
        //}
        //else
        //    CanEnterNorAttack = true;
        //if (CanEnterNorAttack)
        //{
        //    stateMahine.ChangeState(stoneEnemy.stoneTowardState);
        //    other = false;
        //    CanEnterNorAttack = false;
        //}
        //if (other)
        //{
        //    ModeUp = Random.Range(1, 6);
 
        //    other = false;
        //}
    }
}
