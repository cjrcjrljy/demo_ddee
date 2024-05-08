using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject aboutInformation;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //选择存档
    public void Select()
    {
        Debug.Log("select");
        SceneManager.LoadScene("Scenes/GameScene");
    }

    //新建存档
    public void New()
    {
        Debug.Log("new");
        SceneManager.LoadScene("RealPlay");
    }

    //设置
    public void Setting()
    {
        Debug.Log("setting");
    }
    
    //关于
    public void About()
    {
        Debug.Log("about");
        aboutInformation.SetActive(true);
    }
    
    //退出游戏
    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
