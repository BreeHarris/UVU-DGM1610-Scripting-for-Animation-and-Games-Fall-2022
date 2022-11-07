using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;

        if(currentHealth <= 0)
        {
            Destroy(gameObject,deathDelay);
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount; // How much are we going to heal the player
        if(currentHealth >= maxHealth) //Puts a cap on health, so the health isn't over max
        {
            currentHealth = maxHealth;
        }
    }
}
