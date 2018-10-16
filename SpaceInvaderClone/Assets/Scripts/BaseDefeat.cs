
using UnityEngine;

public class BaseDefeat : MonoBehaviour
{

    private Transform playerBase;
	
	void Start ()
	{
	    this.playerBase = GetComponent<Transform>();
	}
	
	
	void Update () {
	    if (this.playerBase.childCount == 0)
	    {
	        GameOver.isPlayerDead = true;
	    }
	}
}
