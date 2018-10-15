using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{

    public static float playerScore = 0;
    private Text scoreText;
	
	void Start ()
	{
	    this.scoreText = GetComponent<Text>();
	}
	
	
	void Update ()
	{
	    this.scoreText.text = "Score: " + playerScore;
	}
}
