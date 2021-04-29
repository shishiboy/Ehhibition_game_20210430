using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject effectPrefab;



    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 0.1f);

          

        }
    }
}
