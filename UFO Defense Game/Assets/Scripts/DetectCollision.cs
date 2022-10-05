using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; // A variable to hold the reference to the ScoreManager
    public int scoreToGive;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase Score amount by scoreToGive value
        Destroy(gameObject); // Destroy this game object
        Destroy(other.gameObject); // Destroy object that passes through trigger
    }
}
