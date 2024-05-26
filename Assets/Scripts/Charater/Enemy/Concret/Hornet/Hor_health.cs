using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hor_health : HleathSystem
{
    public Horent horent;
    public StopDector stopDector;
    public override void Awake()
    {
        base.Awake();
        stopDector = GetComponent<StopDector>();
        horent = GetComponent<Horent>();
    }

    public override void Damage(float damage)
    {
        base.Damage(damage);
        stopDector.HittedTimer = stopDector.ContinueHitted;
    }

    public override void Die()
    {
        base.Die();
    }

    public override void OnEnable()
    {
        base.OnEnable();
    }

    public override void Recevery(float rec)
    {
        base.Recevery(rec);
    }

    public override void Recevery(float rec, int k)
    {
        base.Recevery(rec, k);
    }
}