using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{

    public float health = 1;
	

	void Update () {
	    if (this.health <= 0)
	    {
            Destroy(gameObject);
	    }
	}
}
