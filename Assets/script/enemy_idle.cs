using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_idle : MonoBehaviour
{


    private Animator animator;

    public GameObject talk;

   // public GameObject switch1;

    void Start()
    {
        animator = GetComponent<Animator>();

        talk.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)

    {

       

        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.


        if (collider.CompareTag("Finish"))
        {
            animator.SetBool("switch", true);

            talk.SetActive(true);
        }


    }

    void OnTriggerExit(Collider collider) 
    {


      
        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.


        if ( collider.CompareTag("Finish"))
        {
            animator.SetBool("switch", false);

            talk.SetActive(false);
        }

    }


}