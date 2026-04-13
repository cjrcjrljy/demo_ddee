using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodes : MonoBehaviour
{
    public float life;
    public float last;
    private void OnEnable()
    {
        life = last;
        StartCoroutine(lastt());
    }
    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;
        if (life < 0)
            gameObject.SetActive(false);
    }
    IEnumerator lastt()
    {
        life -= Time.deltaTime;
        yield return null;
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
