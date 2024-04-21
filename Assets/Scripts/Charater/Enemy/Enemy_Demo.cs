using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo : MonoBehaviour
{
    public bool trigger;
    public HleathSystem hleathSystem;
    public Animator animator;
    private void Awake()
    {
        hleathSystem=GetComponent<HleathSystem>();
        animator = GetComponentInChildren<Animator>();
        trigger = false;
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
