using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    
    void FixedUpdate()
    {
        transform.LookAt(player);
    }


    
}


