using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private Animator animator;
    bool isNear;
    public Collider handCollider;
    public Collider bodyCollider;
    public GameObject attacksound;
    public GameObject attacksound2;
    public GameObject flash;
    public GameObject anim;
    public GameObject switch_secret;
    public GameObject characon_switch;
    public GameObject perfect;
    public GameObject porigon;
  //  public GameObject camera_switch;
    public GameObject special;
    public GameObject secret;
    public GameObject sousa_base;

    void Start()
    {

        Animator animator = GetComponent<Animator>();
        isNear = false;
        handCollider = GameObject.Find("Character1_LeftHand").GetComponent<BoxCollider>();
        bodyCollider = GameObject.Find("Character1_body").GetComponent<BoxCollider>();
       
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

        if (Input.GetKeyDown(KeyCode.R) && isNear && anim.activeSelf)
        {

            animator.SetBool("attack", true);
            handCollider.enabled = true;
            Invoke("ColliderReset", 1.0f);
            attacksound.SetActive(true);
            special.SetActive(true);
            Invoke("lesson2_special", 2.0f);
            sousa_base.SetActive(false);

            if (anim.activeSelf)
            {
                Invoke("anim_switch", 0.1f);
            }

        }

        else
        {
            animator.SetBool("attack", false);

        }

        if (Input.GetKeyDown(KeyCode.G) && isNear && anim.activeSelf)
        {

            animator.SetBool("attack2", true);
            bodyCollider.enabled = true;
            Invoke("ColliderReset", 3.0f);
            Invoke("Call2", 1.3f);
            attacksound2.SetActive(true);
        //    camera_switch.SetActive(true);
            Invoke("c_switch", 1.0f);
            secret.SetActive(true);
            Invoke("lesson2_secret", 4.0f);
            sousa_base.SetActive(false);

            if (anim.activeSelf)
            {
                Invoke("anim_switch", 0.1f);
            }
        }

        else
        {
            animator.SetBool("attack2", false);

        }

        if (attacksound.activeSelf)
        {
            Invoke("Call", 0.8f);
        }

        if (attacksound2.activeSelf)
        {
            Invoke("Call", 3.0f);
        }

      

      

    }

   

    private void ColliderReset()
    {
        handCollider.enabled = false;
        bodyCollider.enabled = false;

    }
    void Call()

    {
        attacksound.SetActive(false);
        attacksound2.SetActive(false);
       

    }
    void Call2()

    {
       flash.SetActive(true);
        switch_secret.SetActive(false);

        if (flash.activeSelf)
        {
            Invoke("Call3", 1.0f);
        }

    }
    void Call3()

    {
        flash.SetActive(false);


    }
    void anim_switch()

    {
        anim.SetActive(false);
        Invoke("anim_switch2", 4.0f);
    }

    void anim_switch2()

    {
        anim.SetActive(true);
    }



   

    void lesson2_special()
    {
        special.SetActive(false);
        sousa_base.SetActive(true);

    }

    void lesson2_secret()
    {
        secret.SetActive(false);
        sousa_base.SetActive(true);

    }
}