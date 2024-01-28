using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleRotation : MonoBehaviour
{
    public float rotationSpeed = 200f; 

    void Update()
    {

        transform.Rotate(rotationSpeed * Time.deltaTime,0f ,0f );
    }
}