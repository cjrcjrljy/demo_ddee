using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HleathSystem : MonoBehaviour
{
    public Enity enity;
    public float maxHleath;
    public float currentHleath;
    public bool CanbeAttacked;
    public float CD_for_rec;
    public EntityFx Fx;
    public virtual void Awake()
    {
        enity = GetComponent<Enity>();
        Fx = GetComponent<EntityFx>();
    }
    public virtual void OnEnable()
    {
        CD_for_rec = 0;
        CanbeAttacked = true;
        currentHleath = maxHleath;
    }
    /// <summary>
    /// 如果attack bool为false则会直接返回
    /// </summary>
    /// <param name="damage"></param>
    public virtual void Damage(float damage)
    {
        if (!CanbeAttacked)
        {
            return;
        }
        enity.IsHitted = true;
        StartCoroutine(Fx.FlashFX());
        currentHleath -= damage;
        if (currentHleath <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        if (currentHleath <= 0)
        {
            currentHleath = 0;
            gameObject.SetActive(false);
        }
    }

    public virtual void Update()
    {
        Die();
        CD_for_rec -= Time.deltaTime;
    }
    /// <summary>
    /// 传入具体数字而不是百分比
    /// </summary>
    /// <param name="rec"></param>
    public virtual void Recevery(float rec)
    {
        if (currentHleath == maxHleath || CD_for_rec > 0)
            return;
        currentHleath = Mathf.Clamp(currentHleath + rec, 0, maxHleath);
        CD_for_rec = 20;
    }
    /// <summary>
    /// 带有两个参数是基本实现，没有cd限制
    /// </summary>
    /// <param name="rec"></param>
    /// <param name="k"></param>
    public virtual void Recevery(float rec, int k)
    {
        currentHleath = Mathf.Clamp(currentHleath + rec, 0, maxHleath);
    }
}
