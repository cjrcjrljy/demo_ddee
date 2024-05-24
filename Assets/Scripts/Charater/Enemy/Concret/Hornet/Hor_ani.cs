using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hor_ani :Ene_ani
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
    }

     void OpenEffect()
    {
       effect.gameObject.SetActive(true);
    }
    void CloseEffect()
    {
        effect.gameObject.SetActive(!false);
    }
}
