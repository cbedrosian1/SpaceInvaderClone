using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float maxBound, minBound;

    public GameObject laser;
    public Transform laserSpawn;
    public float fireRate;

    private float nextFire;
    private Transform player;
   


	void Start ()
	{
	    this.player = GetComponent<Transform>();
	}
	

	void FixedUpdate ()
	{
	    float horizontal = Input.GetAxis("Horizontal");

	    if (this.player.position.x < this.minBound && horizontal < 0)
	    {
	        horizontal = 0;
	    }
        else if (this.player.position.x > this.maxBound && horizontal > 0)
	    {
	        horizontal = 0;
	    }

        this.player.position += Vector3.right * this.speed * horizontal;
	}

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > this.nextFire)
        {
            this.nextFire = Time.time + this.fireRate;
            Instantiate(this.laser, this.laserSpawn.position, this.laserSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
}
