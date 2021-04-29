using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timescript2 : MonoBehaviour
{
    private float time = 9;
    //public GameObject Select3;
    public GameObject CountDown;



    void Start()
    {
        //********** 追記 **********// 

        //********** 追記 **********// 
        GetComponent<Text>().text = ((int)time).ToString();
    }

    void Update()
    {

       

        if (CountDown.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {

            SceneManager.LoadScene("0110_1");

        }

        time -= Time.deltaTime;
        //********** 追記 **********// 
        if (time < 0)
        {
            SceneManager.LoadScene("0110_1");

        }

        //********** 追記 **********// 
        if (time < 0) time = 0;
        GetComponent<Text>().text = ((int)time).ToString();





    }


}