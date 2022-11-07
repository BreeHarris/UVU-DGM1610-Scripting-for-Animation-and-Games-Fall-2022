using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot(); // Calls shoot funtion
        }
    }
    
    void Shoot() // Shoot funtion
    {
        Instantiate(projectile,firePoint.position,firePoint.rotation); // Three points, (game object, position, rotation)
    }
}
