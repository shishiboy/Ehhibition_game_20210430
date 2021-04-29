using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suicide_body02 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject suicide_switch01;
    public GameObject suicide_switch02;
    public GameObject suicide_switch03;
    public GameObject suicide_switch04;
    public GameObject suicide_switch05;
    public GameObject suicide_switch06;
    public GameObject suicide_button01;
    public GameObject suicide_touched;


    void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (suicide_switch01.activeSelf)
        {
            animator.SetBool("02_idle", true);
            Invoke("suicide_idle", 2.0f);
            Invoke("suicide_01", 4.0f);
            suicide_button01.SetActive(true);
            animator.SetBool("suisaid_attack_01", true);


        }


        if (suicide_switch02.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {

            suicide_switch03.SetActive(true);
 
            suicide_touched.SetActive(true);
            suicide_button01.SetActive(false);
        }


        if (suicide_switch03.activeSelf & suicide_switch04.activeSelf)
        {
            suicide_switch02.SetActive(false);
            // Animator animator = GetComponent<Animator>();
            animator.SetBool("suisaid_attack_01", false);
            suicide_touched.SetActive(false);
            animator.SetBool("suisaid_attack_02", true);
            Invoke("suicide_02", 2.0f);
            Invoke("suicide_03", 4.0f);
            suicide_button01.SetActive(true);
        }

        if (suicide_switch05.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            suicide_switch06.SetActive(true);
            suicide_touched.SetActive(true);
            suicide_button01.SetActive(false);
        }

        if (suicide_switch05.activeSelf & suicide_switch06.activeSelf)
        {
            //  Animator animator = GetComponent<Animator>();
            animator.SetBool("suisaid_attack_02", false);
            suicide_touched.SetActive(false);
            animator.SetBool("suisaid_attack_03", true);

        }

    }

    void suicide_idle()

    {
        suicide_switch02.SetActive(true);
        suicide_switch01.SetActive(false);
    }



    void suicide_01()

    {
        suicide_switch04.SetActive(true);

    }



    void suicide_02()

    {
        suicide_switch05.SetActive(true);
        suicide_switch03.SetActive(false);
        suicide_switch04.SetActive(false);
    }

    void suicide_03()

    {
        suicide_switch06.SetActive(true);
    }

}

