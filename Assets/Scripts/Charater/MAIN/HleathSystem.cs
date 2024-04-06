using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HleathSystem : MonoBehaviour
{
    public float maxHleath;
    public float currentHleath;
    public bool CanbeAttacked;
    public void OnEnable()
    {
        CanbeAttacked = true;
        currentHleath = maxHleath;
    }
    public void Damage(float damage)
    {
        if(!CanbeAttacked)
        {
            return;
        }
        currentHleath-=damage;
        if (currentHleath <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        if (currentHleath < 0)
        {
            currentHleath = 0;
        }
        gameObject.SetActive(false);
    }
    public void Recevery(float rec)
    {
        currentHleath=Mathf.Clamp(currentHleath+rec, 0, maxHleath);
    }
}
