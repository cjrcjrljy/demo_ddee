using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horent : Enemy
{
    public FitstState fitstState;
    public AttacK_hor attacK_Horstate;
    public Animator EffectAni;
    public BigSkill bigSkill;
    public override void Awake()
    {
        base.Awake();
        fitstState = new FitstState(StateMachine, this, "First", this);
        attacK_Horstate = new AttacK_hor(StateMachine, this, "Attack", this);
        bigSkill = new BigSkill(StateMachine, this, "JumpState",this, "Bigskill");
    }
    public void Start()
    {
        StateMachine.Initialize(fitstState);
    }
    public override void Update()
    {
        base.Update();
    }
}
