using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class re_start : MonoBehaviour
{




    void Start()
    {
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {

            SceneManager.LoadScene("0110_1");

        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            SceneManager.LoadScene("0110_1");

        }







    }


}