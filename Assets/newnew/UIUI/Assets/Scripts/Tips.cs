using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    public GameObject player;
    public GameObject tips;
    private double distance = 100f; 

    void Start()
    {
        
    }

    void Update()
    {
        distance = Mathf.Pow(transform.position.x-player.transform.position.x, 2)+Mathf.Pow(transform.position.y-player.transform.position.y, 2);
        if (distance < 20)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
