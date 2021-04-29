using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class shell : MonoBehaviour
{

    public GameObject effectPrefab;

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Enemy"))
        {

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);
        }
    }
}