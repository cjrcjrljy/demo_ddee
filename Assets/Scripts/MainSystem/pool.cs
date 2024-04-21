using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class pool
{
    public GameObject Prefeb => prefeb;
    public Transform parent;
    public int Size => size;
    public int runsize => queue.Count;
    [SerializeField] int size = 10;
    [SerializeField]public GameObject prefeb;
    Queue<GameObject> queue;
    public void initialize(Transform parent)
    {
        this.parent = parent;
        queue = new Queue<GameObject>();
        for(int i = 0; i < size; i++) 
        {
            queue.Enqueue(copy());
        }
    }
    public GameObject copy()
    {
        var copy = GameObject.Instantiate(prefeb,parent);
        copy.SetActive(false);
        return copy;
    }
    public GameObject Avil()
    {
        GameObject ava = null;
        if (queue.Count > 0&&!queue.Peek().activeSelf)
        {
            ava = queue.Dequeue();
        }
        else
            ava = copy();
        queue.Enqueue(ava);
        return ava; 
    }
    public GameObject prepared()
    {
        GameObject prepare = Avil();
        prepare.SetActive(true);
        return prepare;
    } 
    public GameObject prepared(Vector3 vector)
    {
        GameObject prepare = Avil();
        prepare.SetActive(true);
        prepare.transform.position = vector;
        return prepare;
    }
    public GameObject prepared(Vector3 vector,Quaternion quaternion)
    {
        GameObject prepare = Avil();
        prepare.SetActive(true);
        prepare.transform.position = vector;
        prepare.transform.rotation = quaternion;
        return prepare;
    }
    public GameObject prepared(Vector3 vector,Quaternion quaternion,Vector3 localscale)
    {
        GameObject prepare = Avil();
        prepare.SetActive(true);
        prepare.transform.position = vector;
        prepare.transform.rotation = quaternion;
        prepare.transform.localScale = localscale;
        return prepare;
    }
}

