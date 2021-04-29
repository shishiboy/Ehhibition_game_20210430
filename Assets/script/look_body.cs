using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_body : MonoBehaviour
{

    public Transform verRot;
    public float lookSensitivity = 2f;

    // Use this for initialization
    void Start()
    {

        verRot = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X") * lookSensitivity;
        
        verRot.transform.Rotate(0, -X_Rotation, 0);
        
    }
}