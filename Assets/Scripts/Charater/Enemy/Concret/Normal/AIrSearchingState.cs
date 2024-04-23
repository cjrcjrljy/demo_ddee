using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIrSearchingState : EnemyState
{
    
    public AirEnemy airEnemy;
    public AIrSearchingState(EnemyStateMahine stateMahine, Enemy enemy, string animatorName, AirEnemy airEnemy) : base(stateMahine, enemy, animatorName)
    {
        this.airEnemy = airEnemy;
    }

    public override void Enter()
    {
      
        airEnemy.StartCoroutine(RandomLyMovingCoroutine());
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
      
    }

    public override void Exit()
    {
        base.Exit();
       airEnemy.StopCoroutine(RandomLyMovingCoroutine());
    }


    IEnumerator RandomLyMovingCoroutine()
    {
        Vector3 targetPosition = RandomMovePosition();
       
        while (true)
        {
            if(Vector3.Distance(airEnemy.transform.position, targetPosition) >Mathf.Epsilon)
            {
              Debug.Log(airEnemy.transform.position);
            Debug.Log(targetPosition);
              airEnemy.transform.position=  Vector3.MoveTowards(airEnemy.transform.position, 
                    targetPosition, airEnemy.Movespeed * Time.deltaTime);
            }
            else
            {
                targetPosition=RandomMovePosition();
            }
            yield return null;
        }
    }
    public Vector3 RandomMovePosition()
    {
        Vector3 movePosition = Vector3.zero;
        movePosition.x = Random.Range(airEnemy.LeftUp.x,airEnemy.RightDown.x);
        movePosition.y=Random.Range(airEnemy.RightDown.y,airEnemy.LeftUp.y);
        return  movePosition;
    }

}
