using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField]float steerSpeed = 0.1f;
   [SerializeField]float moveSpeed = 0.01f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(moveSpeed,0,0);
    }
}
