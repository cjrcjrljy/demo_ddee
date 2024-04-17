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
    /// ��ȡ��ǰλ��
    /// </summary>
    public void GetPosition()
    {
        position = player.gameObject.transform.position;
    }
    /// <summary>
    /// �ƶ���ָ��λ��
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
