using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class enemy_stop : MonoBehaviour

{

    private Animator animator;
    private int stop;
    void Start()

    {



        animator = GetComponent<Animator>();

        stop = Animator.StringToHash("stop");

    }




    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void OnTriggerEnter(Collider collider)

    {


        if (collider.gameObject.tag == "Player")
        {

            animator.SetBool(stop, true);

           
        }

    }

  

}