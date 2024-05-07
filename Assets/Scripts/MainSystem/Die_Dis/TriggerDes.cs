using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
