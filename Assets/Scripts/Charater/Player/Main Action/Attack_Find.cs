using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack_Find : MonoBehaviour
{
    public float damage = 10;
    public GameObject Hitvfx;
    public Player player;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy demo))
        {
            // var point = collision.GetContact
            player.HifMusic.SetActive(false);
            player.HifMusic.SetActive(true);
            AttackSense.Instance.HitPause(player.pauseTime);
            AttackSense.Instance.Hitshake(player.shakeTime, player.strengh);
            demo.IsHitted = true;
            poolmanager.Release(Hitvfx, transform.position);
            player.Attack_Change = true;
            if (player.Hleath.currentHleath < player.Hleath.maxHleath)
                player.AttackState.recc(10);
            demo.Hleath.Damage(damage);

        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {

        //if (collision.gameObject.TryGetComponent<Enemy>(out Enemy demo))
        //{

        //    if (player.Hleath.currentHleath < player.Hleath.maxHleath)
        //        player.AttackState.recc(10);
        //    demo.Hleath.Damage(damage);

        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy demo))
        {
         
           demo.IsHitted = true;
            if (player.Hleath.currentHleath<player.Hleath.maxHleath)
                player.AttackState.recc(10);
            demo.Hleath.Damage(damage);
          
        }
    }

   

}
