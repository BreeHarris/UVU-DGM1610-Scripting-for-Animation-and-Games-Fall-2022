using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay;
    public float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnemy;

    public float attackRange;
    public int damage;



    // Update is called once per frame
    void Update()
    {
        if(attackDelay <= 0) // If attack delay is zero allow for attack
        {
            if(Input.GetKey(KeyCode.F)) // Wait for key to be pressed
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy);

                for(int i=0; i < enemiesToDamage.Length; i++) // Key press generates sensor, if enemy is in sensor, apply damage
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }

            attackDelay = startDelay;
        }
        else
        {
            attackDelay -= Time.deltaTime; // Countdown
        }
    }

    // Render gizmos on screen in a red wire sphere
    void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
