using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class enemys : MonoBehaviour

{

   

    [SerializeField] GameObject body;

    public GameObject effectPrefab1;

    public GameObject effectPrefab2;

    public GameObject effectPrefab3;

    public GameObject enemy_s;

    bool One;

    public GameObject soundbomb;



    void Start()

    {
     
        One = true;
        

    }

    void Update()
    {

       
        if (body.activeSelf && One)
        {

            GameObject effect = Instantiate(effectPrefab1, transform.position, Quaternion.identity);


            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);

            One = false;
        }

    }



    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void OnTriggerEnter(Collider collider)

    {
       

        if (collider.gameObject.tag == "Player")
        {

            //zimaku.SetActive(true);

            Destroy(body.gameObject);

            GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);

            GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect2, 2.0f);

            //One = true;
            enemy_s.SetActive(true);

            soundbomb.SetActive(true);

        }

    }

}