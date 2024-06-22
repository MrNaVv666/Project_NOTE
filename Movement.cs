using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    DoubleJump doubleJump;

    [SerializeField] private Transform playerRotator;
    [SerializeField] private Transform playerRotatorStartPos;
    [SerializeField] private CharacterController controller;
    
    //WalkingVariables
    private float speed = 25f;
    private float activeMovespeed;
    private float direction;

    //DashVariables
    private float dashSpeed;
    private float dashLenght = 0.5f;
    private float dashCooldown = 3f;

    private float dashCounter;
    private float dashCoolCounter;
   
   
    void Start()
    {
       PlayerStartPosition();
       controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        

        
        if (Input.GetKey(KeyCode.A))
        {
            direction = 1f;
            RotateFunction();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = -1f;
            RotateFunction();
        }
        else
        {
            direction = 0f;
        }

        

        

    }

    private void PlayerStartPosition()
    {
        playerRotator.transform.position = playerRotatorStartPos.transform.position;
        playerRotator.transform.rotation = playerRotatorStartPos.transform.rotation;

        activeMovespeed = speed;

    }

    private void RotateFunction()
    {
        transform.Rotate(new Vector3(0f, direction * speed * Time.deltaTime, 0f));
    }

    

    

}
