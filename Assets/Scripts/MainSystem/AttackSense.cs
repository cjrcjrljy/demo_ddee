using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSense : MonoBehaviour
{
    public static AttackSense instance ;
    public static AttackSense Instance 
    {
        get
        {
            if(instance== null)
                instance=Transform.FindObjectOfType<AttackSense>();
            return instance;
        }
    }
    public bool isshake;
    public void HitPause(int duration)
    {
        StartCoroutine(Pause(duration));
    }
    public void Hitshake(float duration,float strenghth)
    {
        if (!isshake)
        {
            StartCoroutine(Shake(duration, strenghth));
        }
    }
   IEnumerator Pause(int duration)
    {
        float pausetime = duration / 60f;
        Time.timeScale = 0.01f;
        yield return new WaitForSecondsRealtime(pausetime);
        Time.timeScale = 1;
    }

    IEnumerator Shake(float duration,float strength)
    {
        isshake = true;
        Transform camera = Camera.main.transform;
        Vector3 StartPoistion = camera.position;
        while(duration > 0)
        {
            camera.position = Random.insideUnitSphere * strength + StartPoistion;
            duration -= Time.deltaTime;
            yield return null;
        }
        camera.position = StartPoistion;
        isshake = false;
    }

}
