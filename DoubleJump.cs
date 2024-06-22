using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoubleJump : MonoBehaviour
{

    [SerializeField] private GameObject playerBody;
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform playerRotatorStartingPos;
    [SerializeField] private LayerMask groundMask;

    public float gravity = -10f;
    private float groundDistance = 0.4f;
    private float jumpHeight = 3f;

    bool isGrounded;
    public Vector3 velocity;



    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log(velocity.y);
            Debug.Log(isGrounded);
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

}