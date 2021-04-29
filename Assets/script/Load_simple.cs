using UnityEngine;

using System.Collections;



public class LoadScene_simple : MonoBehaviour

{

    public int score = 0;



    void Awake()

    {

        score = 30;

        DontDestroyOnLoad(gameObject);

    }



    // click callback

    public void OnClick()

    {

        Application.LoadLevel(1);

    }

}