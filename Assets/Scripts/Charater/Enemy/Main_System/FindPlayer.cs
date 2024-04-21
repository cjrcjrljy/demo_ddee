using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public float checkDis;
    public Enemy enemy;
    public LayerMask Player;
   public bool Findpp
    {
        get
        {
            return Physics2D.Raycast(transform.position, Vector2.right, checkDis*enemy.Facingdir ,Player);
        }
    }
    private void Awake()
    {
        enemy = GetComponentInParent<Enemy>();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,new Vector3(transform.position.x+ checkDis*enemy.Facingdir, 
            transform.position.y));
    }
 
}
