using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{
    public CinemachineVirtualCamera nowCamea;
    public CinemachineVirtualCamera willCamea;
    private void OnEnable()
    {
        willCamea.gameObject.SetActive(true);
        StartCoroutine(wait());
    }
    private void OnDisable()
    {
        willCamea.gameObject.SetActive(true);
        //yield return new WaitForSeconds(4f);
        nowCamea.gameObject.SetActive(true);
        willCamea.gameObject.SetActive(false);
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(4f);
        nowCamea.gameObject.SetActive(false);
        willCamea.gameObject.SetActive(false);
    }
    IEnumerator back()
    {
        willCamea.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        nowCamea.gameObject.SetActive(true);
        willCamea.gameObject.SetActive(false);
    }
}
