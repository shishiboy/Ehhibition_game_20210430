﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class b4_1 : MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            SceneManager.LoadScene("b4_1");
        }
    }
}