using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject obstacle;
    public float timeToSpawn = 2;
    public float maxY = -4;
    public float minY = -8;

    float timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        
        if (timer >= timeToSpawn) {
            //Spawn Obstacle
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(8, randomY, 0);
            Instantiate(obstacle, spawnPosition, Quaternion.identity);
            timer = 0;
	}
}
}
