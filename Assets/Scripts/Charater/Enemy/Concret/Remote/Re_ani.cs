using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re_ani : Ene_ani
{
    public RemoteEnemy remoteEnemy;
    public override void Awake()
    {
        remoteEnemy = GetComponentInParent<RemoteEnemy>();
        base.Awake();
    }
    public void AniOut()
    {
        remoteEnemy.StateMachine.CurrrentState.TriggerCalled = true;
    }
}
