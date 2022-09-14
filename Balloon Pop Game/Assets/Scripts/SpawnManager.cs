using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Global Variables, accessed from the inspector and class (or file)
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;

    public float spawnInterval = 1.5f;

    public float xRange = 5; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

   
    void SpawnRandomBalloon()
    {
        // Get a random position on the x-axis 
        Vector3 spawnPosX = new Vector3(Random.Range(-xRange,xRange),0,0); 

        // Pick random balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);

        // Spawn a random balloon at spawn point
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
