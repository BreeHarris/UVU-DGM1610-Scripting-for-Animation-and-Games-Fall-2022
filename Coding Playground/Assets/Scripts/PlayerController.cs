using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables for PC controller
    public float speed = 10.00f;
    public float rotSpeed = 50.0f;
    public Rigidbody playerRb;
    //Input variables
    float hInput; 
    float vInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get keyboard inputs
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        //Move PC forward and backward
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);
        //Rotate the PC left and right
        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);
    }
}
