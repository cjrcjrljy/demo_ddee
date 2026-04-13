using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UIElements;


public class SaveFor
{
    public GameObject player;
    public Player playerPlayer;
    public Vector3 position;
    public ObjectPool<Player> pool;
    /// <summary>
    /// 获取当前位置
    /// </summary>
    public void GetPosition()
    {
        position = player.gameObject.transform.position;
    }
    /// <summary>
    /// 移动到指定位置
    /// </summary>
    /// <param name="position"></param>
    public void ChangePosition()
    {
        player.gameObject.transform.position= position;
    }
    public SaveFor()
    {
        player = GameObject.FindWithTag("Player");
        playerPlayer = player.GetComponent<Player>();
        GetPosition();
        Debug.Log(position);
    }
  
   

}
