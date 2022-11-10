using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100; // Enemy health
    public float speed;

    


    public void TakeDamage(int damage)
    // Deduct health
    {
        health -= damage;
        Debug.Log(damage + " Damage Taken");

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

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy has perished!");
        }
    }
}
