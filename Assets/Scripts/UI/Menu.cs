using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool GameMenu, MainMenu;
    public GameObject MenuDialog, MainMenuDialog;
    public void StartGame()
    {
        Time.timeScale = 1f;
        Physics.gravity = new Vector3(0, -100f, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameMenu)
            {
                Resume();
            }
            else if(GameMenu)
            {
                Pause();
            }
            else if (GameMenu)
            {
                Restart();
            }
            else
            {
                Exit();
            }
        }
    }

    public void Resume()
    {
        
        Time.timeScale = 1f;
        GameMenu = false;
    }

    public void Pause()
    {
        MenuDialog.SetActive(true);
        Time.timeScale = 0f;
        GameMenu = true;
    }

    public void Exit()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("main");
    }

    public void Restart()
    {
        SceneManager.LoadScene("main");
        StartGame();
        Time.timeScale = 1f;
        MainMenuDialog.SetActive(false);
    }

}