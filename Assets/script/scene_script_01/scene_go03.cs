using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class scene_go03 : MonoBehaviour
{

void OnTriggerEnter(Collider hit)
{
    // 接触対象はPlayerタグですか？
    if (hit.CompareTag("Finish"))
    {

        // このコンポーネントを持つGameObjectを破棄する
        SceneManager.LoadScene("L03");
    }
}
}