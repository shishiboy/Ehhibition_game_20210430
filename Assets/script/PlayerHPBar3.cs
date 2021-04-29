using System.Collections;

using System.Collections.Generic;

using UnityEngine;



//UI使うときは忘れずに。

using UnityEngine.UI;



public class PlayerHPBar3 : MonoBehaviour

{

    //最大HPと現在のHP。

    int maxHp = 4000;

    int currentHp;

    //Sliderを入れる

    public Slider slider;

    [SerializeField] GameObject enemyCanvas;


    //[SerializeField] GameObject zimaku;

    [SerializeField] GameObject body;


    float seconds;

    public GameObject effectPrefab1;

    public GameObject effectPrefab2;

    public GameObject effectPrefab3;

    public GameObject effectPrefab4;

    public GameObject effectPrefab5;

    public GameObject damage;

    public GameObject self;

    bool One;



    void Start()

    {


        //Sliderを満タンにする。

        slider.value = 1;

        //現在のHPを最大HPと同じに。

        currentHp = maxHp;

        Debug.Log("Start currentHp : " + currentHp);

        enemyCanvas.SetActive(false);

        //zimaku.SetActive(false);

        One = true;

    }

    void Update()
    {

        seconds += Time.deltaTime;

        if (seconds >= 0.01)
        {


            int plus = 5;

            seconds = 0;
            currentHp = currentHp + plus;

            slider.value = (float)currentHp / (float)maxHp; ;


            if (currentHp > 4000)
            {
                currentHp = 4000;

            }


        }

        //if (self.activeSelf && One )
       // {
       //     GameObject effect = Instantiate(effectPrefab1, transform.position, Quaternion.identity);



            // ★追加
            // エフェクトを２秒後に画面から消す
            //Destroy(effect, 3.0f);

           // One = false;
      //  }

        //if (self.activeSelf && One)
     //   {
            
    //        GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);


            // ★追加
            // エフェクトを２秒後に画面から消す
     //       Destroy(effect, 3.0f);

     //       One = false;
     //   }

        if (self.activeSelf && One)
        {

            GameObject effect = Instantiate(effectPrefab3, transform.position, Quaternion.identity);


            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 1.0f);

            One = false;
        }

    }



    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void OnTriggerEnter(Collider collider)

    {

       

        //Animator animator = GetComponent<Animator>();

        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.
        //int trans = animator.GetInteger("trans");

        //Enemyタグのオブジェクトに触れると発動

        if (collider.gameObject.tag == "Player")

        {

            


            enemyCanvas.SetActive(true);

            //  trans++;
            //transの値を増やす



            //  enemyCanvas.SetActive(true);


            //ダメージは1～100の中でランダムに決める。

            int damage = Random.Range(90, 100);

            Debug.Log("damage : " + damage);



            //現在のHPからダメージを引く

            currentHp = currentHp - damage;

            Debug.Log("After currentHp : " + currentHp);



            //最大HPにおける現在のHPをSliderに反映。

            //int同士の割り算は小数点以下は0になるので、

            //(float)をつけてfloatの変数として振舞わせる。



            Debug.Log("slider.value : " + slider.value);

            // animator.SetInteger("trans", trans);


        }

        if (collider.gameObject.tag == "Finish")

        {

            damage.SetActive(true);

        
        }

        seconds += Time.deltaTime;

        if (seconds >= 0.5)
        {
            damage.SetActive(false);

        }

        if (currentHp <= 0)
        {

            int plus = 0;


            Destroy(enemyCanvas.gameObject);

            //zimaku.SetActive(true);

            body.SetActive(false);

            GameObject effect = Instantiate(effectPrefab4, transform.position, Quaternion.identity);

            // ★追加
            // エフェクトを２秒後に画面から消す
            Destroy(effect, 3.0f);

            One = true;
        }

        if (currentHp <= 0)
        {

            GameObject effect = Instantiate(effectPrefab5, transform.position, Quaternion.identity);

            Destroy(effect, 4.0f);

        }




            // if (enemyCanvas.Destroy)
            // { 

            //  a1room.SetActive(true);

            //}

        }

}