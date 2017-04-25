﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSpawn : MonoBehaviour
{

    public Transform Spawner;
    public Transform NewTileset;
    float speed = 10f;
    float SpawnedTracks = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        SpawnAndDestroy();
	}

    void SpawnAndDestroy()
    {

        if (transform.position.y > 25)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(NewTileset, new Vector3(0, transform.position.y - 200, 0), Quaternion.identity);
            }
        }

        if(transform.position.y > 250)
        {
            Destroy(gameObject);
        }
    }
}