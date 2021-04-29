using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle_2 : MonoBehaviour
{


    private Animator animator;

   

    // public GameObject switch1;

    void Start()
    {
        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)

    {



        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.


        if (collider.CompareTag("Finish"))
        {
            animator.SetBool("switch", true);

            
        }


    }

    void OnTriggerExit(Collider collider)
    {



        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.


        if (collider.CompareTag("Finish"))
        {
            animator.SetBool("switch", false);

           
        }

    }


}