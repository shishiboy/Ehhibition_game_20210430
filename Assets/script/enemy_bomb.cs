using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class enemy_bomb : MonoBehaviour

{

    private Animator animator;
    private int bomb;

    public GameObject body;

    public GameObject enemy_s;

    public GameObject soundbomb;

    public GameObject Delete;

    public GameObject lesson3_select;

    public GameObject game_over;

    //public GameObject explode;

    void Start()

    {

       

        animator = GetComponent<Animator>();

        bomb = Animator.StringToHash("bomb_01");

       

    }

   


        //ColliderオブジェクトのIsTriggerにチェック入れること。

        private void OnTriggerEnter(Collider collider)

    {


        if (collider.gameObject.tag == "Player")
        {

            animator.SetBool(bomb, true);
           
            soundbomb.SetActive(true);
            Delete.SetActive(true);

            //Instantiate(explode, this.transform.position, Quaternion.identity);
            //this.transform.localScale = Vector3.zero;

            if (body.activeSelf)
            {
                Invoke("Call", 4.0f);
                Invoke("Delete_title", 2.0f);
            }

        }
        if (lesson3_select.activeSelf)
        {
            Delete.SetActive(false);
        }

        if (game_over.activeSelf)
        {
            Delete.SetActive(false);
        }

    }

    void Call()

    {
        Destroy(body.gameObject);
        //soundbomb.SetActive(false);
        enemy_s.SetActive(true);
        //Destroy(explode.gameObject);

    }

    void Delete_title()

    {
       Delete.SetActive(false);

    }

}