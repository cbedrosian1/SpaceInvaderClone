﻿
using UnityEngine;

public class LaserController : MonoBehaviour
{

    public float speed;
    public GameObject explosion;
    private Transform laser;

    
	
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
            Instantiate(this.explosion, transform.position, transform.rotation);
        }
        else if (other.tag == "Base")
        {
            GameObject playerBase = other.gameObject;
            BaseHealth baseHealth = playerBase.GetComponent<BaseHealth>();
            baseHealth.health -= 1;
            Destroy(gameObject);
            
        }
    }
}
