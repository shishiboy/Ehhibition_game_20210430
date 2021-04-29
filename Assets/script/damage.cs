using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{

    
    public GameObject damagesound1;
    public GameObject damagesound2;
    public GameObject damageeffect;
    public GameObject hakusyu;

    // Start is called before the first frame update
    void Start()
    {
        damagesound1.SetActive(false);
        damagesound2.SetActive(false);
    }

    

    // Update is called once per frame
    

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {


            damagesound1.SetActive(true);
            damagesound2.SetActive(true);
            damageeffect.SetActive(true);
            hakusyu.SetActive(true);
        }

        if (damagesound1.activeSelf)
        {
            Invoke("Call", 0.8f);
        }

        if (damagesound2.activeSelf)
        {
            Invoke("Call", 4.0f);
        }

        if (damageeffect.activeSelf)
        {
            Invoke("Call2", 0.4f);
        }

        if (hakusyu.activeSelf)
        {
            Invoke("Call2", 0.8f);
        }

    }

    void Call()

    {
        damagesound1.SetActive(false);
        damagesound2.SetActive(false);

    }

    void Call2()

    {
        damageeffect.SetActive(false);
        hakusyu.SetActive(false);

    }

}
