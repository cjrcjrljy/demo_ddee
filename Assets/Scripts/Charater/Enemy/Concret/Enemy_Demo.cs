using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo : NormalEnemy
{

  
    public WaitForSeconds Backtime;
    public Normal_attack normalattackstate;
  
    public float bbacktime;

  

    public override void Awake()
    {
        base.Awake();
        normalattackstate = new Normal_attack(StateMachine, this, "Attack", this);
        Backtime = new WaitForSeconds(bbacktime);
        fouc = new Fouc(StateMachine, this, "Focus");
        searchingForState = new SearchingForState(StateMachine, this, "Ilde", this);
        StateMachine.Initialize(searchingForState);
    }

    public override void Update()
    {
        base.Update();
      
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Checkwall.transform.position, new Vector3(Checkwall.transform.position.x + checkwalldis * Facingdir,
            Checkwall.transform.position.y));
    }
}
