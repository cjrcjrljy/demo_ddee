using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
   public Player player;
    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }
    public void AnimatorTrigger()
    {
         player.stateMachine.CurrentState.TriggerCalled = true;
        player.change_BIG=false; 
        player.Attack_Change=false;
    }
    public void CanChange()
    {
       
        player.change_BIG=true;
    }
    public void attackfeel()
    {
        AttackSense.Instance.HitPause(player.pauseTime);
        AttackSense.Instance.Hitshake(player.shakeTime, player.strengh);
    }
    public void ChangeState_idle()
    {
        player.stateMachine.ChangeState(player.IdleState);
    }
}
