
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour {


	
	
	void Update () {
	    if (GameOver.isPlayerDead)
	    {
	        if (Input.anyKey)
	        {
	            SceneManager.LoadScene("Menu");
	        }
        }
	  
	}
}
