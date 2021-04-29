using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_score : MonoBehaviour
{
    
    [SerializeField] GameObject a1text;
    [SerializeField] GameObject a2text;
    [SerializeField] GameObject a3text;
    [SerializeField] GameObject a4text;
    [SerializeField] GameObject a5text;
    [SerializeField] GameObject a6text;
    [SerializeField] GameObject a7text;
    [SerializeField] GameObject a8text;
    [SerializeField] GameObject a9text;
    [SerializeField] GameObject a10text;
    

    void Start()

    {

        a1text.SetActive(false);
        a2text.SetActive(false);
        a3text.SetActive(false);
        a4text.SetActive(false);
        a5text.SetActive(false);
        a6text.SetActive(false);
        a7text.SetActive(false);
        a8text.SetActive(false);
        a9text.SetActive(false);
        a10text.SetActive(false);
      
    }

        void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("a1"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a1text.SetActive(true);
        }

        if (hit.CompareTag("a2"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a2text.SetActive(true);
        }

        if (hit.CompareTag("a3x"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a3text.SetActive(true);
        }
        if (hit.CompareTag("a3z"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a4text.SetActive(true);
        }
        if (hit.CompareTag("a4"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a5text.SetActive(true);
        }
        if (hit.CompareTag("b1"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a6text.SetActive(true);
        }
        if (hit.CompareTag("b2"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a7text.SetActive(true);
        }
        if (hit.CompareTag("b3x"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a8text.SetActive(true);
        }
        if (hit.CompareTag("b3z"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a9text.SetActive(true);
        }
        if (hit.CompareTag("b4"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            a10text.SetActive(true);
        }
        

    }
}
