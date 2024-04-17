using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TostandManager : MonoBehaviour
{
    public GameObject Reference_right;
    public GameObject Reference_left;
    public GameObject Tostand;
    float y_posi;
    public float x_right;
    public float x_left;
    public Vector3 po; 
    private void Awake()
    {
        x_right=Reference_right.transform.position.x;
        x_left=Reference_left.transform.position.x;
        y_posi = -6.1f;
        po=new Vector3(x_right,y_posi);
    }
    public void RandomInit(int n)
    {
        for(int i=1;i<=n;i++)
        {
            float x=Random.Range(x_left,x_right);
            poolmanager.Release(Tostand, new Vector3(x,y_posi));
        }
    }
}
