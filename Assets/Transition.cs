
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    private Animator animator;

    public GameObject click;

    private bool isNear;

    void Start()
    {
        isNear = false;
        
        click.SetActive(false);
    }



    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish" && isNear )
        {
            isNear = true;
            click.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Finish")
        {
            isNear = false;
            click.SetActive(false);
        }
    }


    void Update()
    {

        Animator animator = GetComponent<Animator>();

        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.


        if (Input.GetKeyDown(KeyCode.Space) && isNear)
        {
            animator.SetBool("Open", true);
        }
    }

}