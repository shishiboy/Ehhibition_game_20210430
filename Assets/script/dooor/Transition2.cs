
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition2 : MonoBehaviour
{

    private Animator animator;

    public GameObject enemy_s1;

    public GameObject enemy_s2;

    public GameObject enemy_s3;

    public GameObject enemy_s4;

    public GameObject click;

    private bool isNear;

    void Start()
    {
        isNear = false;
        
        click.SetActive(false);
    }



    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish" && isNear && enemy_s1.activeSelf && enemy_s2.activeSelf && enemy_s3.activeSelf && enemy_s4.activeSelf)
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


        if (Input.GetKeyDown(KeyCode.Space) && isNear && enemy_s1.activeSelf && enemy_s2.activeSelf && enemy_s3.activeSelf && enemy_s4.activeSelf)
        {
            animator.SetBool("Open", true);
        }
    }

}