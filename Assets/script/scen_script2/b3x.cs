using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class b3x : MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            SceneManager.LoadScene("b3_x");
        }
    }
}