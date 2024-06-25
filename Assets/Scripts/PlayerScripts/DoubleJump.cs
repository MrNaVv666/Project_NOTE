using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoubleJump : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundMask;

    private float gravity = -10f;
    private float groundDistance = 0.4f;
    private float jumpHeight = 3f;

    private float jumpDebugDelayTime = 0.5f;

    private int consoleDebugJumpCounter;

    private bool isGrounded;
    private Vector3 velocity;



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
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            StartCoroutine(JumpDebug());
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private IEnumerator JumpDebug()
    {
        yield return new WaitForSeconds(jumpDebugDelayTime);
        consoleDebugJumpCounter++;
        
        Debug.Log("                                                            " + "||" + consoleDebugJumpCounter + "====================" + consoleDebugJumpCounter + "=====================" + consoleDebugJumpCounter + "||");
        Debug.Log("                                                                                          " + "Is " + "(" + velocity.y + ")" + " Units High");
        Debug.Log("                                                                                          " + "Is On The Ground: " + "|====" + isGrounded + "====|");
        Debug.Log("                                                            " + "||" + consoleDebugJumpCounter + "====================" + consoleDebugJumpCounter + "=====================" + consoleDebugJumpCounter + "||");
        Debug.Log("");
    }

}