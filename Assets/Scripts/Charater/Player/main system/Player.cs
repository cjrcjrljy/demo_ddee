using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player :Enity
{

    public float shakeTime;
    public int pauseTime;
    public float strengh; 

    public PlayerInput input;

    #region "skill_demo"
    public UI_Caowei uI_1;
    public UI_Caowei uI_2;
    public UI_Caowei uI_3;
    public Skill_A _A;
    public Skill_B _B;
    public Skill_C _C;
    public Skill_ready ready;
    public Text text_A;
    public Text text_B;
    public Text text_C;
    public bool change_Skill = false;
    public bool change_BIG = false;
    public SkillStateMachine skillStateMachine;
    #endregion
    #region"State"
    public PlayerStateMachine stateMachine {  get; private set; }
    public IdleState IdleState { get; private set; }
    public MoveState moveState { get; private set; }
    public PlayerPrimaryAttack AttackState { get; private set; }
    public DashState dashState { get; private set; }
    public JumpState jumpState { get; private set; }
    #endregion
    #region "Move"
    public float jumpheigh;
    public float Movespeed;
    #endregion

    #region "Normal"
    public override void  Awake()
    {
        base.Awake();
        input=GetComponent<PlayerInput>();
      
        skillStateMachine=new SkillStateMachine();
        FacingRight = true;
        stateMachine=new PlayerStateMachine();
        dashState = new DashState(this, stateMachine, "Dash",input);
        IdleState=new IdleState(this,stateMachine,"Idle", input);
        moveState = new MoveState(this, stateMachine, "Move", input);
        AttackState=new PlayerPrimaryAttack(this,stateMachine,"Attack", input);
        jumpState = new JumpState(this, stateMachine, "Jump", input);



        _A = new Skill_A("A", skillStateMachine, this);
        _B=new Skill_B("B", skillStateMachine, this);
        _C=new Skill_C("C", skillStateMachine, this);
        ready = new Skill_ready("aaa", skillStateMachine, this);
    }
    public void Start()
    {
        input.EnableGameplayInputs();
        stateMachine.Initialize(IdleState);
        skillStateMachine.Initialize(ready);
    }
    public void Update()
    {

        stateMachine.CurrentState.Update();
        skillStateMachine.State.UPdate();
        if(input.Jump)
            stateMachine.ChangeState(jumpState);
    }
    #endregion


    /// <summary>
    /// 只重置文本显示
    /// </summary>
    /// <param name="text"></param>
    public void init(Text text,UI_Caowei uI)
    {
        StartCoroutine(init_TTT(text,uI));
    } 
    IEnumerator init_TTT(Text text,UI_Caowei uI)
    {
        text.color = Color.red;
        yield return new WaitForSeconds(1);
        text.text = string.Empty;
        skillStateMachine.State.Change_ani(uI);
    }


    /// <summary>
    /// 大技能释放后，等待一段时间切换到ready状态
    /// </summary>
    /// <param name="skillState"></param>
    public void BIg_after(SkillState skillState)
    {
       StartCoroutine(BIGBANG(skillState));
    }
    IEnumerator BIGBANG(SkillState skillState)
    {
        yield return new WaitForSeconds(1);
        skillStateMachine.ChangeState(skillState);
    }
}
