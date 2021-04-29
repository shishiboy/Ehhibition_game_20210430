using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_enemy3 : MonoBehaviour
{

    private Animator animator;
    bool isNear;
    public GameObject attacksound;
    //public GameObject Ienemy;
    public GameObject bomb;
    public GameObject flash;
    public GameObject damage;
    public GameObject end;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {


        //  Ienemy.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (damage.activeSelf)
        {

            animator.SetBool("break", true);
            //attacksound.SetActive(true);
            //   Ienemy.SetActive(true);
            Invoke("Call2", 11.5f);
        }


        //   else
        //   {
        //       animator.SetBool("break", false);

        //    }

        if (attacksound.activeSelf)
        {
            Invoke("Call", 15.5f);
        }

        if (end.activeSelf)
        {

            player.SetActive(false);
            //attacksound.SetActive(true);
            //   Ienemy.SetActive(true);

        }

    }

    void Call()

    {
        attacksound.SetActive(false);

    }

    void Call2()

    {
        bomb.SetActive(true);

        Invoke("Call3", 0.8f);

    }

    void Call3()

    {
        flash.SetActive(true);

    }

}
