using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform playerRotator;
    [SerializeField] private Transform playerRotatorStartPos;
    
    //RunningVariables
    private float speed = 25f;
    private float direction;

    void Start()
    {
        RotatorStartPosition();
    }

    void Update()
    {
        ApplyMovement();
    }

    private void RotatorStartPosition()
    {
        playerRotator.transform.position = playerRotatorStartPos.transform.position;
        playerRotator.transform.rotation = playerRotatorStartPos.transform.rotation;
    }

    private void ApplyMovement()
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

    private void RotateFunction()
    {
        transform.Rotate(new Vector3(0f, direction * speed * Time.deltaTime, 0f));
    }

    

    

}
