using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hor_ani : Ene_ani
{
    public Horent horent;
    public Animator effect;
    public override void Awake()
    {
        base.Awake();
        effect = horent.EffectAni;
    }

    public void Effect_Attack()
    {
        OpenEffect();
        effect.Play("AttacK_nor");
        horent.Setvelocity(horent.Facingdir * horent.Movespeed * 3, 0);

    }

    public void Effect_Big()
    {
        OpenEffect();
        effect.Play("BigSkill");
        horent.Setvelocity(0, 0);
    }

    public void dash()
    {
        horent.FacingPlayer();
        Vector3 position = (horent.Target.transform.position - transform.position).normalized;
        position *= position.magnitude /Mathf.Abs( position.y)*  horent.DashSpeed;
        horent.rb.gravityScale = 0;
        horent.Setvelocity(position.x,position.y);
    }

    #region "nothing"
    void OpenEffect()
    {
        effect.gameObject.SetActive(true);
    }
    void CloseEffect()
    {
        effect.gameObject.SetActive(!false);
    }
    void ControlGra()
    {
        horent.rb.gravityScale = 1;
    }
    #endregion
}
