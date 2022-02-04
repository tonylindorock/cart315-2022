using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float walkSpeed = 7.5f;
    public float runSpeed = 11.5f;
    public float jumpSpeed = 8.0f;
    public float jumpHeight = 3f;
    public float gravity = -9.8f;
    public float gravityMultipler = 4f;
    public Camera playerCamera;
    public float lookSpeed = 10f;
    public float lookXLimit = 90f;

    public Transform groundCheck;
    public float groundDis = 0.4f;
    public LayerMask groundMask;

    CharacterController controller;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;
    Vector3 velocity;

    bool isGrounded = false;

    public bool canLook = true;
    public bool canMove = true;

    public GameObject weapon;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDis, groundMask);
        // update directions
        float x = 0f;
        float z = 0f;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // Move the controller
        controller.Move(move * walkSpeed * Time.deltaTime);

        // if on ground
        if (isGrounded && controller.isGrounded && velocity.y < 0f) {
            velocity.y = -2f;
        }

        // handle jump
        if (Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity * gravityMultipler);
        }

        // apply gravity
        velocity.y += gravity * gravityMultipler * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        // Player and Camera rotation
        if (canLook){
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;

            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);

            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }

    public void addWeapon(){
        weapon.SetActive(true);
    }
}