using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningObj : MonoBehaviour
{
    public float MovingTime;
    public Player player;
    public int MovingDir;
    Vector3 target;
    public float MovingSpeed;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    private void OnEnable()
    {
        StartCoroutine(nameof(KeepMoving));
    }
    private void OnDisable()
    {
        StopAllCoroutines();
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
        float movedis = Dis * 1.5f;
        Vector3 mid=new Vector3(transform.position.x+movedis*MovingDir,
            transform.position.y,transform.position.z);

        return mid;
    }
    
 IEnumerator  KeepMoving()
    {
        Vector3 target= GetDis();
        while (true)
        { 
            if(Vector3.Distance(transform.position, target)>Mathf.Epsilon)
            {
                transform.position= Vector3.MoveTowards(transform.position, 
                    target,MovingSpeed* Time.deltaTime);
            }
            else
                target = GetDis();
          MovingTime-=Time.deltaTime;
            if(MovingTime < 0)
            {
               AppearDamge();
            }
            yield return null;
        }
    }

    public void AppearDamge()
    {
        Debug.Log("HONHO");
        gameObject.SetActive(false);
    }
}
