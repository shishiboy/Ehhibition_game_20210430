using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ver2 : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            SceneManager.LoadScene("ver2_0609");
        }
    }
}
