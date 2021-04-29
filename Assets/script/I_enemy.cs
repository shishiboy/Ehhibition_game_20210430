                                                                                                                                           using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_enemy : MonoBehaviour
{

    private Animator animator;
    public GameObject damage;
    public GameObject bomb;
    public GameObject flash;
    public GameObject sound;
    public GameObject end;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        


    }

  

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (damage.activeSelf)
        {
            animator.SetBool("break", true);

            Invoke("Call", 14.5f);
        }


        ///     else
        //   {
        //       animator.SetBool("break", false);

        //     }

        if (end.activeSelf)
        {

            player.SetActive(false);
            //attacksound.SetActive(true);
            //   Ienemy.SetActive(true);

        }

    }

    void Call() 
    
    {
        sound.SetActive(true);
        Invoke("Call2", 0.8f);
       
    }

    void Call2()

    {
        flash.SetActive(true);
    }

}
