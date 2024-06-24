using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoubleJump : MonoBehaviour
{

    [SerializeField] private GameObject playerBody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform playerRotatorStartingPos;
    [SerializeField] private LayerMask groundMask;
    private RigidBody3D playerRigidbody;

    private float groundDistance = 0.4f;
    private float jumpHeight = 3f;

    bool isGrounded;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody3D>;
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
            playerRigidbody.velocity = new Vector3(0, jumpHeight, 0);
        }
    }
}
