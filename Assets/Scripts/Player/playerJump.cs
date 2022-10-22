using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
// [RequireComponent(typeof(Rigidbody))]
public class playerJump : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        // StartCoroutine(Delay());
    }

    void OnCollisionStay(){
        isGrounded = true;
        jumpForce = 0f;
    }

    // IEnumerator Delay()
    // {
    //     yield return new WaitForSeconds(2);
    // }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // public float jumpSpeed;
    // private float ySpeed;

    // void Update()
    // {
    //     ySpeed += Physics.gravity.y * Time.deltaTime;
    //     if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
    //     {
    //         ySpeed = jumpSpeed;
    //     }
    // }






    // public float speed;
    // public float rotationSpeed;
    // public float jumpSpeed;

    // private CharacterController characterController;
    // private float ySpeed;
    // private float originalStepOffset;

    // void Start()
    // {
    //     characterController = GetComponent<CharacterController>();
    //     originalStepOffset = characterController.stepOffset;
    // }

    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");

    //     Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
    //     float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
    //     movementDirection.Normalize();

    //     ySpeed += Physics.gravity.y * Time.deltaTime;

    //     if (characterController.isGrounded)
    //     {
    //         characterController.stepOffset = originalStepOffset;
    //         ySpeed = -0.5f;

    //         if (Input.GetButtonDown("Jump"))
    //         {
    //             ySpeed = jumpSpeed;
    //         }
    //     }
    //     else
    //     {
    //         characterController.stepOffset = 0;
    //     }

    //     Vector3 velocity = movementDirection * magnitude;
    //     velocity.y = ySpeed;

    //     characterController.Move(velocity * Time.deltaTime);

    //     if (movementDirection != Vector3.zero)
    //     {
    //         Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

    //         transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    //     }
    // }

}
