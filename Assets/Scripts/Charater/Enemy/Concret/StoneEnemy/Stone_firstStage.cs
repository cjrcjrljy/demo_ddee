using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class Stone_firstStage : EnemyState
{
    public StoneEnemy stoneEnemy;
    public bool CanEnterNorAttack;
    public bool CanEnterRemoteFal;
    public int ModeAttack;
    public int ModeUp=0;
    public Stone_firstStage(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, StoneEnemy stoneEnemy) : base(stateMahine, enemy, animatorName)
    {
        ModeAttack = 0;
        ModeUp = 5; 
        this.stoneEnemy = stoneEnemy;
    }

    public override void Enter()
    {
        base.Enter();
        
        ChangeMode();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
       
        if (TriggerCalled)
            stateMahine.ChangeState(stoneEnemy.stone_FirstStage);
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
            CanEnterNorAttack=false;
        }
        if (CanEnterRemoteFal)
        {
            ModeUp = Random.Range(1, 6);
            stateMahine.ChangeState(stoneEnemy.remoteFal);
            CanEnterRemoteFal=false;
        }
    }
}
