using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool GameMenu;
    public GameObject MenuDialog;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameMenu)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        MenuDialog.SetActive(false);
        Time.timeScale = 1f;
        GameMenu = false;
    }

    public void Pause()
    {
        MenuDialog.SetActive(true);
        Time.timeScale = 0f;
        GameMenu = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

}