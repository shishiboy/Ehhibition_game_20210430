using System.Collections.Generic;
using UnityEngine;

public class ani_walk : MonoBehaviour
{
    private Animator animator;
    bool isNear;
    public GameObject characon_switch;
    public GameObject perfect;
    public GameObject porigon;



    void Start()
    {

        Animator animator = GetComponent<Animator>();
        isNear = false;




    }




    void Update()
    {

        if (characon_switch.activeSelf)
        {
            isNear = true;
        }

        if (perfect.activeSelf)
        {
            isNear = false;
        }

        if (porigon.activeSelf)
        {
            isNear = false;
        }

        Animator animator = GetComponent<Animator>();


        if (characon_switch.activeSelf && Input.GetKey(KeyCode.W))
        {

            animator.SetBool("Do Walk", true);
        }



        else
        {

            animator.SetBool("Do Walk", false);
        }

        if (characon_switch.activeSelf && Input.GetKey(KeyCode.S))
        {

            animator.SetBool("Go Back", true);
        }


        else
        {

            animator.SetBool("Go Back", false);
        }
    }

 

}




