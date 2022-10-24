using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{
    private PlatformEffector2D effector2D;
    public float waitTime; 

    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Resets wait time when the key is released
        if(Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0.5f;
        }
        // Flipping effector down
        if(Input.GetKey(KeyCode.S))
        {
            if(waitTime <= 0) // if wait time is reduced to 0 flip effector down
            {
                effector2D.rotationalOffset = 180f;
                waitTime = 0.5f; // Sets wait time

            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        // Flip effector back up
    if(Input.GetKey(KeyCode.W))
    {
        effector2D.rotationalOffset = 0;
    }

    }
    
}
