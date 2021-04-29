using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood : MonoBehaviour
{
    public GameObject effectPrefab;

    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)

    {

        if (collider.gameObject.tag == "Player")

        {

            GameObject effect = Instantiate(effectPrefab, this.transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);


        }
    }
}