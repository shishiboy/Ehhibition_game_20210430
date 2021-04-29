using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    // ★追加
    // エフェクトプレハブのデータを入れるための箱を作る。
    public GameObject effectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            // ★追加
            // エフェクトを実体化（インスタンス化）する。
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);
        }

        if (other.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            // ★追加
            // エフェクトを実体化（インスタンス化）する。
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);
        }

    }
}