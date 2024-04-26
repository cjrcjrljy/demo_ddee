using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_ani : MonoBehaviour
{
    public Enemy demo;
    public Animator animator;
    public virtual void Awake()
    {
        animator=GetComponent<Animator>();
        demo = GetComponentInParent<Enemy>();
    }
}
