using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public float checkDis;
    public LayerMask Player;
   public bool Findpp
    {
        get
        {
            return Physics2D.Raycast(transform.position, Vector2.right, checkDis, Player);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,new Vector3(transform.position.x+checkDis,transform.position.y));
    }
 
}
