using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rb;

    void Awake()
    {
        // Get components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; // Getting input for left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed; // Getting input for forward and back
       
        //Walk in direciton player is looking in
        Vector3 dir = transform.right * x + transform.forward * z
        dir.y = rb.velocity.y; //Direction
        //rb.velocity = new Vector3(x, rb.velocity.y, z); // Apply velocity to the x and z axes to drive player
        
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; // Look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // Look left and right

        //Restrict movement on the X-Axis between maxLookX to minLookX
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
    // Drives Camera rotation  
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
