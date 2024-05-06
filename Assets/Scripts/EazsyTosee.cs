using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EazsyTosee : MonoBehaviour
{
    public float Radi;
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, Radi);
    }
}
