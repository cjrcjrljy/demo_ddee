using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Find : MonoBehaviour
{
    public float damage = 10;
    public Player player;

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy demo))
        {
            Debug.Log(player._A.currrec);

            if (player.Hleath.currentHleath < player.Hleath.maxHleath)
                player.AttackState. recc(10);
            demo.Hleath.Damage(damage);
        
        }
    }
}
