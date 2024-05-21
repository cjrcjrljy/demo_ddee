using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondState : EnemyState
{
    public StoneEnemy stoneEnemy;
    public bool CanEnterNorAttack;
    public bool CanEnterRemoteFal;
    public int ModeAttack=0;
    public int ModeUp = 5;
    public int ModeChange = 0;
    public SecondState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.stoneEnemy = stoneEnemy;
    }

    public override void Enter()
    {
        ModeChange = Random.Range(0,100);
        Debug.Log(ModeAttack);
        base.Enter();
        AttackMode_Change();
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
        if (ModeChange >= 0 && ModeChange <= 70)
            ChangeMode();
        else 
            stateMahine.ChangeState(stoneEnemy.crazyState);
        
    }

    public void ChangeMode()
    {
        ModeAttack++;
        ModeAttack %= ModeUp;
        if (ModeAttack == 0)
        {
            CanEnterRemoteFal = true;
        }
        else
            CanEnterNorAttack = true;
        if (CanEnterNorAttack)
        {
            stateMahine.ChangeState(stoneEnemy.stoneTowardState);
            CanEnterRemoteFal = false;
            CanEnterNorAttack = false;
        }
        if (CanEnterRemoteFal)
        {
            ModeUp = Random.Range(1, 6);
            stateMahine.ChangeState(stoneEnemy.remoteFal);
            CanEnterRemoteFal = false;
        }
    }
}
