using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    #region "Basic Func"
    public PlayerStateMachine StateMachine;
    public string AnimatorName;
    public Rigidbody2D rb;
    public Player player;
    public bool TriggerCalled=false;
    #endregion
    #region "import Aciton"
    public float Xinput;
    #endregion
    public PlayerState(Player _player,
        PlayerStateMachine _statemachine,
        string _animator)
    {
        this.player = _player;
        this.StateMachine = _statemachine;
        this.AnimatorName = _animator;

    }
    public virtual void Enter()
    {
        TriggerCalled = false;
        player.animator.SetBool(AnimatorName, true);
        rb = player.rb;
    }
    public virtual void Update()
    {
        Xinput = Input.GetAxis("Horizontal");
    }
    public virtual void Exit()
    {
        player.animator.SetBool(AnimatorName, false);
    }
}