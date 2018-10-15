using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{

    public static bool isPlayerDead = false;

    private Text gameOver;
	
	void Start ()
	{
	    this.gameOver = GetComponent<Text>();
	    this.gameOver.enabled = false;
	}
	
	
	void Update () {
	    if (isPlayerDead)
	    {
	        Time.timeScale = 0;
	        this.gameOver.enabled = true;
	    }
	}
}
