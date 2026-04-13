using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Caowei : MonoBehaviour
{
   public Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
