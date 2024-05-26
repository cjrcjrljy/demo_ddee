using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horent : Enemy
{
    public FitstState fitstState;
    public AttacK_hor attacK_Horstate;
    public Animator EffectAni;
    public BigSkill bigSkill;
    public HorJumpAttack horJump;
    public FallState horfallstate;
    public AttackGap gap;
    public float DashSpeed;
    public StopDector stopDector;
    public bool STOP => stopDector.Stop;
    public HorStopState horStop;


    public float Jump_y;
    public float Jump_x;
    public override void Awake()
    {
        base.Awake();
        Time.timeScale = 0.09f;
        stopDector = GetComponent<StopDector>();
        gap = new AttackGap(StateMachine, this, "Gap", this);
        horfallstate = new FallState(StateMachine, this, "Fall", this);
        fitstState = new FitstState(StateMachine, this, "First", this);
        attacK_Horstate = new AttacK_hor(StateMachine, this, "Attack", this);
        bigSkill = new BigSkill(StateMachine, this, "Bigskill",this);
        horJump = new HorJumpAttack(StateMachine, this, "JumpAttack", this);
        horStop = new HorStopState(StateMachine, this, "Stop", this);
    }
    public void Start()
    {
        StateMachine.Initialize(horStop);
    }
    public override void Update()
    {
        if(STOP)
        {
            StateMachine.ChangeState(horStop);
            stopDector.CloseStop();

        }
        if (IsGrounded)
        {
            animator.SetBool("JumpState", false);
            animator.SetBool("Isgroud", true);
        }
        else
        {
            animator.SetBool("JumpState", true);
            animator.SetBool("Isgroud", false);
        }
        base.Update(); 
    }
}
