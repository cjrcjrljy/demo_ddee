using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo :Enemy
{
 
    public override void Awake()
    {
        base.Awake();
      
    } 
    void Start()
    {
      
    }

  
    void Update()
    {
      
    }
    public void EnterHitted()
    {
        animator.SetBool("Hitted", true);
    }
}
