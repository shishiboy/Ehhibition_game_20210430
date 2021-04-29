using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_script : MonoBehaviour
{
    public GameObject effect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Animator animator = GetComponent<Animator>();


        if (effect.activeSelf)
        {
         //   animator.SetBool("fade", true);
            Invoke("Call", 4.0f);
        }
    }
    void Call()

    {
        effect.SetActive(false);


    }
}
