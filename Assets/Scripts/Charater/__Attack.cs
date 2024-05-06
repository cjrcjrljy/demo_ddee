using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Attack : MonoBehaviour
{
    public GameObject Fx;
    public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision. gameObject.TryGetComponent<HleathSystem>(out HleathSystem hleathSystem))
        {
            poolmanager.Release(Fx, transform.position);
            hleathSystem.Damage(damage);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<HleathSystem>(out HleathSystem hleathSystem))
        {

            hleathSystem.Damage(damage);
        }
    }
}
