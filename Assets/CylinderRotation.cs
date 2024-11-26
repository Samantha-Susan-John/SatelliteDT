using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        float rotationSpeed = 20.0f; // Define the rotation speed
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0)); // Rotate the GameObject around the Y-axis
    }
}
