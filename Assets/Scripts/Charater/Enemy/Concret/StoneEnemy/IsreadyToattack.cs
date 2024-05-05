using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsreadyToattack : MonoBehaviour
{
    public bool isReadyToAttack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isReadyToAttack = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isReadyToAttack = false;
    }
}
