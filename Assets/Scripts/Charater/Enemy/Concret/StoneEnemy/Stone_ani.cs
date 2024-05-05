using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_ani :Ene_ani
{
    public StoneEnemy stoneEnemy;
    public override void Awake()
    {
        base.Awake();
        stoneEnemy = GetComponentInParent<StoneEnemy>();
    }
    public override void TriggerOut()
    {
        base.TriggerOut();
    }
}