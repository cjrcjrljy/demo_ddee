using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_up : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy_Demo>(out Enemy_Demo demo))
        {
            demo.trigger = true;

        }
    }
}
