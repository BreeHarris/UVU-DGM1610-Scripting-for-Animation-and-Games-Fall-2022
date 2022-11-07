using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100; // Enemy health


    public void TakeDamage (int damage)
    // Deduct health
    {
        health -= damage;

        if(health <= 0) // Check to see if the enemy health has been reduced to 0
        {
            Death(); //Run death method
        }
    }

    void Death()
    {
        // Add sound and particle effects
        Destroy(gameObject);
    }
}
