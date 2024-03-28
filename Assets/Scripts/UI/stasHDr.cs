using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stasHDr : MonoBehaviour
{
    public Canvas canvas;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvas .worldCamera=Camera.main;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
