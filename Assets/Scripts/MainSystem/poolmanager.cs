using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolmanager : MonoBehaviour
{
    [SerializeField]public pool[] StandPools;


    public static Dictionary<GameObject, pool> dic;
    public void Awake()
    {
      dic = new Dictionary<GameObject, pool>();
        initialize(StandPools);
     
    }
    public void OnDestroy()
    {
      
    }
    public void checksize(pool[] pools)
    {
        foreach(var pool in pools)
        {
            if (pool.runsize > pool.Size)
                Debug.LogWarning("bigger");
        }
    }
    void initialize(pool[] pools)
    {
        foreach (var pool in pools)
        {
#if UNITY_EDITOR
            if (dic.ContainsKey(pool.Prefeb))
            {
                Debug.LogError("same prefab in same dictionary: " + pool.Prefeb.name);
                continue;
            }
#endif
            dic.Add(pool.Prefeb, pool);
           
           
            Transform poolparent= new GameObject("Pool: " +pool.Prefeb.name).transform;
            poolparent.parent = transform;
            pool.initialize(poolparent);
        }
    }
    public static GameObject Release(GameObject prefab)
    {
#if UNITY_EDITOR
        if(!dic.ContainsKey(prefab))
        {
            Debug.LogError("Pool manager cannot find prefab: "+prefab.name);
            return null;
        }
#endif
        return dic[prefab].prepared();
    }  
    public static GameObject Release(GameObject prefab,Vector3 position)
    {
#if UNITY_EDITOR
     
        if (!dic.ContainsKey(prefab))
        {
            Debug.LogError("Pool manager cannot find prefab: "+prefab.name);
            return null;
        }
#endif
        return dic[prefab].prepared(position);
    }
    public static GameObject Release(GameObject prefab,Vector3 position,Quaternion rotate)
    {
#if UNITY_EDITOR
        if(!dic.ContainsKey(prefab))
        {
            Debug.LogError("Pool manager cannot find prefab: "+prefab.name);
            return null;
        }
#endif
        return dic[prefab].prepared(position,rotate);
    }
    public static GameObject Release(GameObject prefab,Vector3 position,Quaternion rotate,Vector3 localscale)
    {
#if UNITY_EDITOR
        if(!dic.ContainsKey(prefab))
        {
            Debug.LogError("Pool manager cannot find prefab: "+prefab.name);
            return null;
        }
#endif
        return dic[prefab].prepared(position,rotate,localscale);
    }




}
