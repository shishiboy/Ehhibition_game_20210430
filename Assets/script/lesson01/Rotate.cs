using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1));
        }
    }
}