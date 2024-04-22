using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Enity : MonoBehaviour
{
    [Header("Must")]
    #region "check"
    public GroundDectector Dectector;
    public bool IsGrounded => Dectector.Isgound;
    public bool IsFailing => rb.velocity.y < 0f && !IsGrounded;
    public bool IsHitted;
    public GameObject detectorForSomething;
    #endregion



    public Animator animator;
    public Rigidbody2D rb;
    public HleathSystem Hleath;
    public bool FacingRight;
    public int Facingdir = 1;
    public virtual void Awake()
    {
        Dectector = GetComponentInChildren<GroundDectector>();
        Hleath = GetComponent<HleathSystem>();
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
     
    }
    public void Facingontroller()
    {
        if (FacingRight && rb.velocity.x < -0.1)
        {
            Filp();
            return;
        }
        if ((!FacingRight) && rb.velocity.x > 0.1)
        {
            Filp();
            return;
        }
    }
    public void Filp()
    {
        FacingRight = !FacingRight;
        Facingdir *= -1;
        rb.transform.localScale = new Vector3(Facingdir, rb.transform.localScale.y, rb.transform.localScale.z);
    }

    public void Setvelocity(float x, float y)
    {
        rb.velocity = new Vector2(x, y);
    }

}
