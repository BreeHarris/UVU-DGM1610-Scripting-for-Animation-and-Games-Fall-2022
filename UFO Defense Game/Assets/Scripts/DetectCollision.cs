using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager; // A variable to hold the reference to the ScoreManager
    public int scoreToGive;
    public ParticleSystem explosionParticle; // Store particle system


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        explosionParticle.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        Explosion();
        scoreManager.IncreaseScore(scoreToGive); // Increase Score amount by scoreToGive value
        Destroy(gameObject); // Destroy this game object
        Destroy(other.gameObject); // Destroy object that passes through trigger
        
        
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
        explosionParticle.Stop();
    }
}
