using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingGuidenceSystem : MonoBehaviour
{
    public float RotateAngle;
    public GameObject target;
    public AudioSource source;
    public AudioClip clip;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
        target = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnEnable()
    {
        source.clip = clip;
        source.Play();
       RandomRote();
        StartCoroutine(MoveToward());
    }
    public void Rotate()
    {
        Vector3 need = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(need.y, need.x) * Mathf.Rad2Deg;
        angle = (angle >= 180) ? angle - 360 : angle; // 如果角度大于等于180度，则调整为范围内的等效角度
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    public void RandomRote()
    {
        float angle = Random.Range(-90, 90);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.07f);
    }
    IEnumerator MoveToward()
    {
        while(true)
        {
            Rotate();
            Move();
            yield return null;
        }
    }
}
