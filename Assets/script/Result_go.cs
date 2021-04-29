using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_go : MonoBehaviour
{

    [SerializeField] GameObject result;
  


    void Start()

    {

        result.SetActive(false);
      

    }

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("end"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            result.SetActive(true);
        }

       
    }
}
