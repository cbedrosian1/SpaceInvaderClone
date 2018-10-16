
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour {


	
	
	void Update () {
	    if (Input.GetKeyDown(KeyCode.R))
	    {
	        PlayerScore.playerScore = 0;
	        GameOver.isPlayerDead = false;
	        Time.timeScale = 1f;

            SceneManager.LoadScene("Game");
	    }
	}
}
