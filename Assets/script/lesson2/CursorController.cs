using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public GameObject porigon;
    public GameObject lesson3_title;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (porigon.activeSelf) {

            Cursor.visible = true;
        }

        if (lesson3_title.activeSelf)
        {

            Cursor.visible = false;
        }

       
    }
}