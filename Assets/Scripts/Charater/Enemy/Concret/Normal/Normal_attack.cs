using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Normal_attack : Fouc
{
    public Enemy_Demo demo;
    public Normal_attack(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, Enemy_Demo demo) : base(stateMahine, enemy, animatorName)
    {
        this.demo = demo;
    }

    public override void Enter()
    {
        demo.StartCoroutine(WaitforBack());
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
      demo.StopCoroutine(WaitforBack());
    }

    public override void Update()
    {
        base.Update();
    }
    IEnumerator WaitforBack()
    {
        yield return demo.Backtime;
        demo.StateMachine.ChangeState(demo.forState);
    }
}
