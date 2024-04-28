using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAttack : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Vel_x;
    public float Vel_y;
    public float dir_x;
    public float dir_y;
    public GameObject target;
    public bool change = false;
    private void Awake()
    {
        
        target = GameObject.FindGameObjectWithTag("Player");
        rb=GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }
    private void OnEnable()
    {
       
        GetDir();
        change = false;
        Debug.Log(dir_x + " " + dir_y);
       
        SetVelociry(Vel_x * dir_x, Vel_y * dir_y);

    }
    private void Update()
    {
        if (!change)
        {
            GetDir();
            Debug.Log(dir_x + " " + dir_y);

            SetVelociry(Vel_x * dir_x, Vel_y * dir_y);
            change = true;
        }
    }
    public void SetVelociry(float x,float y)
    {
     
        rb.velocity=new Vector2 (x,y);
    }
    public void GetDir()
    {
        dir_x=(target.transform.position.x-transform.position.x);
        dir_y=target.transform.position.y-transform.position.y;
        Vector2 mid=new Vector2(dir_x,dir_y).normalized;
        dir_x = mid.x; dir_y=mid.y;
        if(Mathf.Abs(dir_y)<.2f)
            dir_y = 0f;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
      gameObject.SetActive(false);
    }
}
