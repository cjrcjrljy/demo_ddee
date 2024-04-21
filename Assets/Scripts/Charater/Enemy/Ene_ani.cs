using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_ani : MonoBehaviour
{
    public Enemy_Demo demo;
    private void Awake()
    {
        
        demo = GetComponentInParent<Enemy_Demo>();
    }
    public void sset()
    {
        demo.animator.SetBool("Hitted", false);

    }
}
