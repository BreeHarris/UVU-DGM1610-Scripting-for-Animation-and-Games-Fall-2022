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
    //public int curHP;

    private Camera camera;
    private Rigidbody rb;

    /*void Awake()
    {
        //weapon = GetComponent<weapon>();
        curHp = maxHp;
    }
*/
    // Start is called before the first frame update
    void Start()
    {
       // Get components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>(); 
    }

    /*public void GiveHealth(int amountToGive)
    {
        //curHP = mathf.Clamp(curHP + amountToGive, 0, maxHP)
        //GameUI.instance.UpdateHealthBar(curHP, maxHP);
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
            Die();

    }

    public void GiveAmmo(int amountToGive)
    {
        weapon.curAmmo = mathf.Clamp(weapon.curAmmo + amountToGive, 0, weapon.maxAmmo);
    }

    void Die()
    {
        //GameManager.instance.LoseGame();
    }
*/

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();


        // Jump button
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
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y; //Direction
        //rb.velocity = new Vector3(x, rb.velocity.y, z); // Apply velocity to the x and z axes to drive player
        rb.velocity = dir; // Move directional based on camera movement
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
