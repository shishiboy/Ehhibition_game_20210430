using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movie_system : MonoBehaviour
{
    public GameObject lesson1;
    public GameObject lesson2;
    public GameObject lesson3;
    public GameObject Switch1;
    public GameObject audio;
    public GameObject lesson1_audio;
    public GameObject lesson2_audio;
    public GameObject lesson3_audio;
    public GameObject body_select;
    public GameObject Enemy_body1;
    public GameObject Enemy_body2;
    public GameObject Enemy_body3;
    public GameObject Enemy_body4;
    public GameObject lesson2_title;
    public GameObject lesson3_title;
    public GameObject monitor3_movie;
    public GameObject monitor2_movie;
    public GameObject HP;
    public GameObject damagecube_2;
    public GameObject damagecube_3;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {

      //  body_select.SetActive(false);
     //   Enemy_body1.SetActive(false);
     //   Enemy_body2.SetActive(false);
     //   Enemy_body3.SetActive(false);
     //   Enemy_body4.SetActive(false);
     //   Switch1.SetActive(false);
     //   lesson2_title.SetActive(false);
     //   audio.SetActive(false);
     //   lesson3_title.SetActive(false);
     //   HP.SetActive(false);
     //   damagecube_2.SetActive(false);
    //    damagecube_3.SetActive(false);
   


    }

    // Update is called once per frame
    void Update()
    {


        if (lesson1.activeSelf)
        {
            Invoke("lesson1_fin", 10.0f);
           
        }

        if (lesson2.activeSelf)
        {

            Invoke("lesson2_fin", 10.0f);
      

        }

        if (lesson3.activeSelf)
        {
            Invoke("lesson3_fin", 10.0f);
     
        }
    }

    public void lesson1_fin()

    {
        lesson1.SetActive(false);
        Switch1.SetActive(true);
        audio.SetActive(true);
        lesson1_audio.SetActive(false);
        Destroy(body_select);
        

    }

    public void lesson2_fin()

    {
        lesson2.SetActive(false);
        Switch1.SetActive(true);
        Enemy_body1.SetActive(true);
        Enemy_body2.SetActive(true);
        Enemy_body3.SetActive(true);
        Enemy_body4.SetActive(true);
        lesson2_title.SetActive(true);
        audio.SetActive(true);
        lesson2_audio.SetActive(false);
        camera.SetActive(false);
        monitor2_movie.SetActive(false);
        
    }



    public void lesson3_fin()

    {
        lesson3.SetActive(false);
        Switch1.SetActive(true);
        lesson3_title.SetActive(true);
        audio.SetActive(true);
        HP.SetActive(true);
        damagecube_2.SetActive(true);
        damagecube_3.SetActive(true);
        lesson3_audio.SetActive(false);
        camera.SetActive(false);
        monitor3_movie.SetActive(false);

    }
}
