using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TostandManager : MonoBehaviour
{
    public List<GameObject> Tostands;
    public GameObject tostand;
    public int hinder;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public float Y_fir;
    public float Y_sec;
    public float Y_thi;
    public float x_min;
    private void Awake()
    {
        Y_fir=one.transform.position.y;
        Y_sec=two.transform.position.y;
        Y_thi=three.transform.position.y;
        x_min=one.transform.position.x;
    }
    private void Start()
    {
        Init_(x_min, Y_fir, 2, 0);
        Init_(x_min,Y_sec, 2, 2);
        Init_(x_min,Y_thi, 2, 4);
    }
    public void Init_(float ori_x,float or_y,int much,int ff)
    {
        for(int i=ff;i<much+ff;i++)
        {
            if (i >= Tostands.Count)
            {
                GameObject  id= GameObject.Instantiate(tostand);
                Tostands.Add(id);
            }
               Tostands[i].transform.position = new Vector3(ori_x + (i-ff) * hinder,or_y);
            Tostands[i].gameObject.SetActive(true);
        }
    }
    public void Appear(int i)
    {
        if(i>Tostands.Count) {
            Debug.Log("NONO");
            return;
        }
        Tostands[i].gameObject.SetActive(true);
    }
    public void Return()
    {
        int i = 0;
        for(;i<Tostands.Count;i++)
        {
            if (Tostands[i].gameObject.activeSelf)
            {
                Tostands[i].gameObject.SetActive(false);
            }
        }
    }
}
