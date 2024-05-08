using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBack : MonoBehaviour
{
    public Camera camre;
    public float ParaxFlow;
    public float Xposition;
    // Start is called before the first frame update
    void Start()
    {
        camre=Camera.main;
        Xposition=transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distomove=camre.transform.position.x*ParaxFlow;
        transform.position = new Vector3(Xposition + distomove, camre.transform.position.y);
    }
}
