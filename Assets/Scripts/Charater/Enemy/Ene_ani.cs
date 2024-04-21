using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_ani : MonoBehaviour
{
    public Enemy demo;
    public Animator animator;
    private void Awake()
    {
        animator=GetComponent<Animator>();
        demo = GetComponentInParent<Enemy>();
    }
    public void PPlay(string aniname)
    {
        animator.speed = 0;
       animator.Play(aniname);
        animator.speed= 1;
    }
}
