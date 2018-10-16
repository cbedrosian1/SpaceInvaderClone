using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserController : MonoBehaviour
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
        this.laser.position += Vector3.up * -this.speed;

        if (this.laser.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(this.explosion, transform.position, transform.rotation);
            GameOver.isPlayerDead = true;
            Time.timeScale = .2f;
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
