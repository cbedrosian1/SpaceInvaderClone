
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{

    public static float playerScore;
    private Text scoreText;
	
	void Start ()
	{
	    this.scoreText = GetComponent<Text>();
	    playerScore = 0;
	}
	
	
	void Update ()
	{
	    this.scoreText.text = "Score: " + playerScore;
	}
}
