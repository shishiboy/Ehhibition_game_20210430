using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret_camera : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject camera_switch;

    void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();
        if (camera_switch.activeSelf)
        {
            animator.SetBool("secret_camera", true);
            Invoke("c_switch", 4.0f);
        }
       
    }

    void c_switch() 
    
    {
        Animator animator = GetComponent<Animator>();
        animator.SetBool("secret_camera", false);

    }


}
