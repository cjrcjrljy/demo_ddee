using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tostand:MonoBehaviour
{
    int position_x;
    int position_y;
    public void OnEnable()
    {
        transform.position=new Vector2 (position_x,position_y);
    }
}
