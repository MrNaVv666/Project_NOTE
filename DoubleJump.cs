using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoubleJump : MonoBehaviour
{

    [SerializeField] private GameObject playerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform playerRotatorStartingPos;
    [SerializeField] private LayerMask groundMask;
    private RigidBody3D playerRigidBody;

    private float groundDistance = 0.4f;
    private float jumpHeight = 3f;

    bool isGrounded;

    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody3D>;
    }


    void Start()
    {

    }

    void Update()
    {
        PlayerJump();
    }

    private void PlayerJump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidBody.velocity = new Vector3(0, jumpHeight, 0);
        }
    }
}
