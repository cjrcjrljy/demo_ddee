using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFx : MonoBehaviour
{
    public SpriteRenderer sr;
    [Header("Flash FX")]
    public Material HitMat;
    public Material originalMat;
    private void Awake()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
    }
    private void Start()
    {
        originalMat = sr.material;
        
    }
    public IEnumerator FlashFX()
    {
        sr.material = HitMat;
        yield return new WaitForSeconds(0.5f);
        sr.material = originalMat;
    }
}
