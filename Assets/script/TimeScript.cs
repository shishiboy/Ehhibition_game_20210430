using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript : MonoBehaviour
{
    private float time = 240;
    //public GameObject Select3;
    public GameObject bgm;
    public GameObject CountDown;
    public GameObject perfect;
    public GameObject Gameover;


    void Start()
    {
        //********** 追記 **********// 
      
        //********** 追記 **********// 
        GetComponent<Text>().text = ((int)time).ToString();
    }

    void Update()
    {

       

        if (perfect.activeSelf)
        {

            CountDown.SetActive(false);

        }

        time -= Time.deltaTime;
        //********** 追記 **********// 
        if (time < 0)
        {
          Gameover.SetActive(true);
            //Select3.SetActive(false);
            bgm.SetActive(false);
            Destroy(CountDown);


        }

        //********** 追記 **********// 
        if (time < 0) time = 0;
        GetComponent<Text>().text = ((int)time).ToString();

       

       

    }

   
}