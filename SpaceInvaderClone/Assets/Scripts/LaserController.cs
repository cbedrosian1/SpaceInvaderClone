using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{


    private Transform laser;

    public float speed;
	
	void Start ()
	{
	    this.laser = GetComponent<Transform>();
	}

    void FixedUpdate()
    {
        this.laser.position += Vector3.up * speed;

        if (this.laser.position.y >= 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
        else if (other.tag == "Base")
        {
            Destroy(gameObject);
        }
    }
}
