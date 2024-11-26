using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing2Rotation : MonoBehaviour
{
    private Transform WingConnector2; // Reference to the WingConnector1 GameObject
    public float rotationSpeed = 10.0f; // Speed of rotation

    // Start is called before the first frame update
    void Start()
    {
        // Find the WingConnector1 child GameObject (modified name)
        WingConnector2 = transform.Find("WingConnector2");
    }

    // Update is called once per frame
    void Update()
    {
        
        WingConnector2.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
    }
}
