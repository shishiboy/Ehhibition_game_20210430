using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class a4_2 : MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            SceneManager.LoadScene("a4_2");
        }
    }
}