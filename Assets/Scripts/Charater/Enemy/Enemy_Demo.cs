using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Demo : MonoBehaviour
{
    public float daojishi;
    public bool trigger;
    public HleathSystem hleathSystem;
    public Animator animator;
    private void Awake()
    {
        hleathSystem=GetComponent<HleathSystem>();
        animator = GetComponentInChildren<Animator>();
        daojishi = -2;
        trigger = false;
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(daojishi > 0 )
            daojishi-=Time.deltaTime/2;
    }
    public void EnterHitted()
    {
        animator.SetBool("Hitted", true);
    }
}
