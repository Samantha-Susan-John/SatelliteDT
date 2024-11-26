using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing1Rotation : MonoBehaviour
{
    private Transform WingConnector1; // Reference to the WingConnector1 GameObject
    public float rotationSpeed = 10.0f; // Speed of rotation

    // Start is called before the first frame update
    void Start()
    {
        // Find the WingConnector1 child GameObject (modified name)
        WingConnector1 = transform.Find("WingConnector1");
    }

    // Update is called once per frame
    void Update()
    {
        
        WingConnector1.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
    }
}
