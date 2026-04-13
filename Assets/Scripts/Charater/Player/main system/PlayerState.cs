using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerState
{
    #region "Basic Func"
    public PlayerStateMachine StateMachine;
    public string AnimatorName;
    public Rigidbody2D rb;
    public Player player;
    public bool TriggerCalled = false;
    #endregion
    #region "import Aciton"
    public float Xinput;
    #endregion
    public PlayerInput Input;
    public PlayerState(Player _player,
        PlayerStateMachine _statemachine,
        string _animator,
        PlayerInput input)
    {
        this.player = _player;
        this.StateMachine = _statemachine;
        this.AnimatorName = _animator;
        Input = input;
    }
    public virtual void Enter()
    {
        TriggerCalled = false;
        player.animator.SetBool(AnimatorName, true);
        rb = player.rb;
    }
    public virtual void Update()
    {
        //Xinput = Input.GetAxis("Horizontal");
        if (player.IsGrounded)
            if (player.input.Jump)
                StateMachine.ChangeState(player.jumpState);
       
    }
    public virtual void Exit()
    {
        player.animator.SetBool(AnimatorName, false);
    }
}