﻿
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
        GameOver.isPlayerDead = false;


    }

    public void QuitGame()
    {
        Application.Quit();
        
    }
}
