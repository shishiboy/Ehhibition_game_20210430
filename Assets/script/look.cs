using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{


    public Transform horRot;
    public float lookSensitivity = 2f;
    // Use this for initialization
    void Start()
    {


        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        float Y_Rotation = Input.GetAxis("Mouse Y") * lookSensitivity;

        horRot.transform.Rotate(Y_Rotation, 0, 0);

       
            


    }
}

