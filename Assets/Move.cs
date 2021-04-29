using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    // Rigidbodyコンポーネントを入れる変数"rb"を宣言する。 
    public Rigidbody rb;
    public GameObject switch1;
    private Animator animator;

    public GameObject go;
    public GameObject back;
    public GameObject left;
    public GameObject right;
    public GameObject sousa_base;
    //   public GameObject special;
    //   public GameObject secret;

    void Start()
    {
        // Rigidbodyコンポーネントを取得する 
        rb = GetComponent<Rigidbody>();
        switch1.SetActive(false);
    }


    void FixedUpdate()
    {
        Animator animator = GetComponent<Animator>();

        // Wキーで前に進む 
        if (switch1.activeSelf && Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * 3.0f;
            go.SetActive(true);
            sousa_base.SetActive(false);
            Invoke("lesson2_go", 3.0f);
            //         animator.SetBool("Do Walk", true);
        }

        


        // Sキーで後ろに進む 
        if (switch1.activeSelf && Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * -3.0f;
            back.SetActive(true);
            Invoke("lesson2_back", 3.0f); 
            sousa_base.SetActive(false);
            //         animator.SetBool("DoWalk", true);
        }

        

        // Rightキーで右回転 
        if (switch1.activeSelf && Input.GetKey(KeyCode.A))
      {
            rb.MovePosition(transform.position - transform.up * 1.0f * Time.deltaTime);
            left.SetActive(true);
            rb.velocity = transform.right * -3.0f;
            Invoke("lesson2_left", 3.0f);
            transform.Rotate(new Vector3(0, -1, 0));
            sousa_base.SetActive(false);
        }

       

        // Leftキーで左回転 
        if (switch1.activeSelf && Input.GetKey(KeyCode.D))
          
          {
            rb.MovePosition(transform.position - transform.up * 1.0f * Time.deltaTime);
            right.SetActive(true);
            rb.velocity = transform.right * 3.0f;
            Invoke("lesson2_right", 3.0f);
            transform.Rotate(new Vector3(0, 1, 0));
            sousa_base.SetActive(false);
        }

        
    }

    void lesson2_go()

    {
        go.SetActive(false);
        rb.velocity = transform.forward * 0.0f;
        sousa_base.SetActive(true);
    }

    void lesson2_back()
        
    {
        back.SetActive(false);
        rb.velocity = transform.forward * -3.0f;
        sousa_base.SetActive(true);
    }

    void lesson2_left()

    {
        left.SetActive(false);
        rb.MovePosition(transform.position - transform.up * 1.0f * Time.deltaTime);     
        rb.velocity = transform.right * 0.0f;
        transform.Rotate(new Vector3(0, 0, 0));
        sousa_base.SetActive(true);
    }

    void lesson2_right()

    {
        right.SetActive(false);
        rb.MovePosition(transform.position - transform.up * 1.0f * Time.deltaTime);
        rb.velocity = transform.right * 0.0f;
        transform.Rotate(new Vector3(0, 0, 0));
        sousa_base.SetActive(true);
    }

}