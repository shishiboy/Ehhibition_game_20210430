using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

//UI使うときは忘れずに。

using UnityEngine.UI;



public class MYHP : MonoBehaviour

{

    //最大HPと現在のHP。

    int maxHp = 95;

    int currentHp;

    //Sliderを入れる

    public Slider slider;

    public GameObject last;
    public GameObject end_s;

    void Start()

    {

        //Sliderを満タンにする。

        slider.value = 1;

        //現在のHPを最大HPと同じに。

        currentHp = maxHp;

        Debug.Log("Start currentHp : " + currentHp);


    }




    //ColliderオブジェクトのIsTriggerにチェック入れること。

    private void OnTriggerEnter(Collider collider)

    {

        //Enemyタグのオブジェクトに触れると発動

        if (collider.gameObject.tag == "Respawn")

        {

            //ダメージは1～100の中でランダムに決める。

            int damage = 10;

            Debug.Log("damage : " + damage);



            //現在のHPからダメージを引く

            currentHp = currentHp - damage;

            Debug.Log("After currentHp : " + currentHp);



            //最大HPにおける現在のHPをSliderに反映。

            //int同士の割り算は小数点以下は0になるので、

            //(float)をつけてfloatの変数として振舞わせる。

            slider.value = (float)currentHp / (float)maxHp; ;

            Debug.Log("slider.value : " + slider.value);


            if (currentHp <= 0)
            {

                last.SetActive(true);
            }

            if (last.activeSelf) {

                Invoke("Call", 17f);
                Invoke("Call2", 2f);

            }



        }
    }

        void Call()

        {

            Quit();

        }

    void Call2()

    {

        end_s.SetActive(true);

    }

    void Quit()
    {

        SceneManager.LoadScene("0110_1");

        //#if UNITY_EDITOR
       // UnityEditor.EditorApplication.isPlaying = false;
//#elif UNITY_STANDALONE
  //  UnityEngine.Application.Quit();
//#endif
    }

}