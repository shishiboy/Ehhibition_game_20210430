using System.Collections.Generic;
using UnityEngine;

public class attack2 : MonoBehaviour
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
    public GameObject camera_switch;
    public GameObject special;
    public GameObject secret;
    public GameObject sousa_base;

    void Start()
    {

        Animator animator = GetComponent<Animator>();
        isNear = false;
    

        handCollider = GameObject.Find("hand.R").GetComponent<BoxCollider>();
        bodyCollider = GameObject.Find("spine.006").GetComponent<BoxCollider>();

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
            Invoke("Call6", 1.2f);
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
            Invoke("Call2", 0.1f);
            camera_switch.SetActive(true);
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
       

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Lastmonitor")
        {
            isNear = false;

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
        


    }
    void Call2()

    {
       
        attacksound2.SetActive(true);
        Invoke("Call3", 2.5f);
        Invoke("Call4", 1.0f);


    }
    void Call3()

    {
      
        attacksound2.SetActive(false);

    }
    void Call4()

    {
        flash.SetActive(true);
        Invoke("Call5", 2.0f);
    }

    void Call5()

    {
        flash.SetActive(false);

    }
    void Call6()

    {
        attacksound.SetActive(true);
        Invoke("Call7", 1.0f);
    }

    void Call7()

    {
        attacksound.SetActive(false);
        
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

    void c_switch() 
    {
        camera_switch.SetActive(false);
    }

    void lesson2_special()
    {
        special.SetActive(false);
        sousa_base.SetActive(true);

    }

    void lesson2_secret()
    {
        secret.SetActive(true);

    }

}

