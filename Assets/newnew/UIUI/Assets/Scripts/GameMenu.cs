using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //返回
    public void Back()
    {
        Debug.Log("back");
        gameObject.SetActive(false);
        
    }

    //保存存档
    public void Save()
    {
        Debug.Log("save");
    }

    //返回主菜单
    public void MainMenu()
    {
        Debug.Log("mainMenu");
        SceneManager.LoadScene("Scenes/StartScene");
    }

    //设置
    public void Setting()
    {
        Debug.Log("setting");
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
