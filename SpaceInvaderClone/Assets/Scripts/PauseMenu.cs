
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        this.audioMixer.SetFloat("volume", volume);
    }

    void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
	        if (!isPaused)
	        {
	            Pause();
            }
	       
	    }
	}

    public void Resume()
    {
        this.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        
    }

    public void Pause()
    {
        this.pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.isPaused = true;
       
    }

    public void MainMenu()
    {
        PauseMenu.isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
