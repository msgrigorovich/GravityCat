using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public bool MainMenu;

    public GameObject MainMenuDialog;
    
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("main");
    }
}
