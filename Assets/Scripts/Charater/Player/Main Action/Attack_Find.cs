using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Find : MonoBehaviour
{
    public float damage = 10;
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.TryGetComponent<Enemy_Demo>(out Enemy_Demo demo))
        {
            Debug.Log("attc");
            demo.hleathSystem.Damage(damage);
            demo.EnterHitted();
        }
    }
}
