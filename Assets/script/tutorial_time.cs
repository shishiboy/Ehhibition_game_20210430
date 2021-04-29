using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_time : MonoBehaviour
{

    public GameObject tutorial;
    public GameObject f_select;
    public GameObject sound;
   


    // Start is called before the first frame update
    void Start()
    {

        f_select.SetActive(false);
       // sound.SetActive(false);
        //select.SetActive(false);


        if (tutorial.activeSelf)
        {
            Invoke("Call", 10f);
        }
    }

    // Update is called once per frame
    void Call()

    {

        tutorial.SetActive(false);
        //sound.SetActive(true);
        f_select.SetActive(true);
        //select.SetActive(true);
        sound.SetActive(false);
       

    }

   

}
