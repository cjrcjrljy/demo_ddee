using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningObj : MonoBehaviour
{
    public float Maxmovtime;
    public float MovingTime;
    public Player player;
    public int MovingDir;
    Vector3 target;
    public GameObject Light;
    public float MovingSpeed;
    public bool IsMoving;
    private void Awake()
    {
        
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    private void OnEnable()
    {
        MovingTime = Maxmovtime;
        IsMoving = true;
        StartCoroutine(nameof(KeepMoving));
    }
  
    private void OnDisable()
    {
        StopCoroutine(nameof(KeepMoving));
    }
    public Vector3 GetDis()
    {
        if (transform.position.x < player.transform.position.x)
        {
            MovingDir = 1;
        }
        else
            MovingDir = -1;
        float Dis=Mathf.Abs(transform.position.x - player.transform.position.x);
        float movedis = Dis * 0.5f;
        Vector3 mid=new Vector3(player.transform.position.x+movedis*MovingDir,
            transform.position.y,transform.position.z);
       
        return mid;
    }
    
 IEnumerator  KeepMoving()
    {
         target= GetDis();
        while (true)
        { 
            if(IsMoving)
            {
                if (Vector3.Distance(transform.position, target) > Mathf.Epsilon)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                        target, MovingSpeed * Time.deltaTime);
                }
                else
                {
                    target = GetDis();
                    if (Mathf.Abs(target.x - player.transform.position.x) < 0.05f)
                       IsMoving = false;

                }

            }
          MovingTime-=Time.deltaTime;
        if(MovingTime < 0)
                AppearDamge();
            yield return null;
        }
    }

    public void AppearDamge()
    {
      
        poolmanager.Release(Light,this.transform.position);
        StopCoroutine(nameof(KeepMoving));
        gameObject.SetActive(false);
    }
}
