using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stasHDr : MonoBehaviour
{
    public Canvas canvas;
    public Image image;
    public HleathSystem Hleath;
    public float currentfix=1;
    public virtual void Awake()
    {
        //image = GetComponentInChildren<Image>();
        canvas = GetComponent<Canvas>();
        canvas .worldCamera=Camera.main;
        Initial();
    }
    void Initial()
    {
        image.fillAmount = 0;
    }
    public void UpFix_Image(float fix_)
    {
        image.fillAmount = fix_;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        UpFix_Image(currentfix);
    }
}
