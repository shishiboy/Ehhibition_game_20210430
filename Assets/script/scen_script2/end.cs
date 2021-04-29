using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            SceneManager.LoadScene("end");
        }
    }
}