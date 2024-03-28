using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFOR : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
