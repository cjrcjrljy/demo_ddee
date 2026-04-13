using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_HDR :stasHDr
{
    
    public override void Awake()
    {

        base.Awake();
    }
    public override void Update()
    {
        base.Update();
        ChangeCurrent();
    }
    public void ChangeCurrent()
    {
        currentfix = Hleath.currentHleath / Hleath.maxHleath;
    }
}