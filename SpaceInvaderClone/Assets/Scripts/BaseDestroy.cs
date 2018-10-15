using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDestroy : MonoBehaviour {

    private Transform playerBase;

    void Start()
    {
        this.playerBase = GetComponent<Transform>();
    }


    void Update()
    {
        if (this.playerBase.childCount == 0)
        {
            Destroy(gameObject);
        }
    }
}
