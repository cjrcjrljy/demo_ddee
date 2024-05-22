using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene("GGamePPlay");
        Time.timeScale = 1f;
        Debug.Log("Hit");
    }
    public void Exit()
    {
        SceneManager.LoadScene("HH");
    }
}
