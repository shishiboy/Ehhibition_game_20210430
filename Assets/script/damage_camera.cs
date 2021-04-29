using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class damage_camera : MonoBehaviour

{

    private Animator animator;
    private int bomb;



    void Start()

    {



        animator = GetComponent<Animator>();

        bomb = Animator.StringToHash("damage");

    }




    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void OnTriggerEnter(Collider collider)

    {


        if (collider.gameObject.tag == "Respawn")
        {

            animator.SetBool(bomb, true);
            Invoke("Call", 0.5f);
           
        }

    }

    void Call()

    {
        animator.SetBool(bomb, false);

    }



}