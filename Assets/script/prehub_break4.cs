using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class prehub_break4 : MonoBehaviour

{



    [SerializeField] GameObject body;
    public GameObject effectPrefab2;
    public GameObject soundbomb;



    void Start()

    {


    }

    void Update()
    {


        if (body.activeSelf)
        {

            Invoke("Break1", 13.0f);

        }

    }



    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void Break1()

    {

        Destroy(body.gameObject);

        GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);

        Destroy(effectPrefab2, 2.0f);

        soundbomb.SetActive(true);


        if (soundbomb.activeSelf)
        {

            Invoke("Break1", 1.5f);

        }

    }


    private void Sound()

    {

       
        soundbomb.SetActive(false);



    }


}