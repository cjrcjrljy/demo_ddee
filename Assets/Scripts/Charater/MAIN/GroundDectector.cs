using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDectector : MonoBehaviour
{
    [SerializeField] float detectorRadus=0.1f;
    [SerializeField] Collider2D[] collider2Ds = new Collider2D[1];
    public LayerMask ground;
    public bool Isgound
    {
        get
        {
            return Physics2D.OverlapCircleNonAlloc(transform.position, detectorRadus, collider2Ds, ground) != 0;

        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectorRadus);
    }
}
