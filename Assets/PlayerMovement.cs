using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Transform orientation;
    public Terrain script;
    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;

    public float groundDrag;
    public float playerHeight;
    public LayerMask whatIsGround; 
    bool grounded;

    public float jumpHeight;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 2f, whatIsGround);
        Debug.DrawRay(transform.position, Vector3.down, Color.blue);
        MyInput();

        if (grounded)
        {
            rb.drag = groundDrag;

        } else
        {
            rb.drag = 1;
        }
        /*if (gameObject.transform.position.y < -128)
        {
            //add loading screen here
            Debug.Log("refried beans");
            script.Reset();
            gameObject.transform.position = new Vector3(0, 128, 0);
            
        }*/



        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (grounded && Input.GetKey("space"))
        {
            rb.AddForce(new Vector3(0, jumpHeight * 1.5f, 0), ForceMode.Force);
        }
    }
    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
    }
    //hi

}
