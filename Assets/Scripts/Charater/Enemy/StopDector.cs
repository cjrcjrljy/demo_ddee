using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDector : MonoBehaviour
{
    public bool Stop = false;
    public float ContinueHitted;
    public float StopTime;
    public float HittedTimer;
    public float MaxTrigger;
    public float CurrTrigger;
    public float Sub;
    public float Add;
    public bool canbeHitted;
    private void Awake()
    {

        canbeHitted = true;
    }
    // Update is called once per frame
    void Update()
    {
        Sub_tri();
        HittedTimer-= Time.deltaTime;
        if (CurrTrigger >= MaxTrigger)
            Stop = true;
        if(Stop)
        {
          
       
            CurrTrigger = 0;
        }
    }
    public void Sub_tri()
    {
        if (!canbeHitted)
            return;
        if (HittedTimer > 0)
            CurrTrigger += Add*Time.deltaTime;
        else
        {
            CurrTrigger -= Sub*Time.deltaTime/2f;
            CurrTrigger=Mathf.Max(0, CurrTrigger);
        }
    }    
    public  void CloseStop()
    {
        Stop = false;
        Debug.Log("Close");
    }
}
