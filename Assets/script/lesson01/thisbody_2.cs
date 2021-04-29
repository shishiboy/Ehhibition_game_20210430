using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisbody_2 : MonoBehaviour
{


    public GameObject thisbody1;
    public GameObject thisbody2;
    public GameObject thisbody3;
    public GameObject thisbody4;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public GameObject enemys1;
    public GameObject enemys2;
    public GameObject enemys3;
    public GameObject enemys4;


    public GameObject thisbodysound;
    public GameObject damage3;
    public GameObject damage2;

    public GameObject audio;

    public GameObject lesson1;
    public GameObject lesson2;
    public GameObject lesson3;
    public GameObject tyuunyuutyu;


    [SerializeField] GameObject Select1;
    public GameObject Select2;
    public GameObject Select3;


    public GameObject f_lesson1_sound;
    public GameObject f_lesson2_sound;
    public GameObject f_lesson3_sound;
    public GameObject s_lesson1_sound;
    public GameObject s_lesson2_sound;
    public GameObject s_lesson3_sound;
    public GameObject t_lesson1_sound;
    public GameObject t_lesson2_sound;
    public GameObject t_lesson3_sound;


    public GameObject Enemy_body1;
    public GameObject Enemy_body2;
    public GameObject Enemy_body3;
    public GameObject Enemy_body4;


    [SerializeField] GameObject l1_title;
    [SerializeField] GameObject lesson2_title;
    [SerializeField] GameObject lesson3_title;

    public GameObject lesson1_audio;
    public GameObject lesson2_audio;
    public GameObject lesson3_audio;
    public GameObject tyunyu_audio;

    public GameObject monitor1_movie;
    public GameObject monitor2_movie;

    public GameObject HP;

    public GameObject damagecube_2;
    public GameObject damagecube_3;

    public GameObject colider;

    public GameObject body_select;
    public GameObject camera;

    public GameObject Directional_light;
    public GameObject Directional_light2;
    public GameObject R_light;
    public GameObject G_light;
    public GameObject B_light;

    public GameObject bgm;
    //public GameObject status;

    public GameObject error_00;
    public GameObject error_01;
    public GameObject error_02;
    public GameObject error_03;
    public GameObject error_04;
    public GameObject error_05;
    public GameObject error_06;
    public GameObject error_07;
    public GameObject error_08;
    public GameObject error_09;

    public GameObject BackPanel;
    public GameObject WhitePanel;
    public GameObject freeze;

    public GameObject Countdown;
    public GameObject Porigon;

    public GameObject op_tutorial;
    public GameObject sound;

    public GameObject switch_skip1;
    public GameObject switch_skip2;
    public GameObject switch_skip3;
    public GameObject switch_lesson1;
    public GameObject switch_lesson2;
    public GameObject switch_lesson3;
    public GameObject switch_body;
    public GameObject switch_body1;
    public GameObject switch_body2;
    public GameObject switch_body3;
    public GameObject switch_body4;

    public GameObject perfect;

    public GameObject characon_switch;
    public GameObject switch_secret;
    public GameObject error_audio;
    public GameObject first_enemy;

    public GameObject switch_error00;
    public GameObject switch_error01;
    public GameObject switch_error02;
    public GameObject switch_error03;
    public GameObject switch_error04;
    public GameObject switch_error05;
    public GameObject switch_error06;
    public GameObject switch_error07;
    public GameObject switch_error08;
    public GameObject switch_error09;
    public GameObject switch_error10;
    public GameObject errorSE;
  //  public GameObject errorSE_lesson1;
  //  public GameObject errorSE_lesson2;
  //  public GameObject errorSE_lesson3;
    public GameObject ketteiSE;
    public GameObject trueSE;
    public GameObject switch_error;
    public GameObject error_error;
    public GameObject gameover;
    public GameObject continue_obj;
    public GameObject continue_count;
    // public GameObject Button_skip1;
    public GameObject lesson2_tenmetu;
    public GameObject cngratulation;
    public GameObject sousaban;
    public GameObject remaining__enemy;
    public GameObject tikarawaza_1;
    public GameObject delete;

    //public GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {


        //Cursor.visible = false;

        thisbody1.SetActive(false);
        thisbody2.SetActive(false);
        thisbody3.SetActive(false);
        thisbody4.SetActive(false);


        enemy1.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
        enemy4.SetActive(true);

        enemys1.SetActive(false);
        enemys2.SetActive(false);
        enemys3.SetActive(false);
        enemys4.SetActive(false);

        thisbodysound.SetActive(false);


        damage2.SetActive(false);
        damage3.SetActive(false);

        lesson1.SetActive(false);
        lesson2.SetActive(false);
        lesson3.SetActive(false);

        Enemy_body1.SetActive(false);
        Enemy_body2.SetActive(false);
        Enemy_body3.SetActive(false);
        Enemy_body4.SetActive(false);

        lesson2_title.SetActive(false);
        lesson3_title.SetActive(false);

        f_lesson1_sound.SetActive(false);
        f_lesson2_sound.SetActive(false);
        f_lesson3_sound.SetActive(false);
        s_lesson1_sound.SetActive(false);
        s_lesson2_sound.SetActive(false);
        s_lesson3_sound.SetActive(false);
        t_lesson1_sound.SetActive(false);
        t_lesson2_sound.SetActive(false);
        t_lesson3_sound.SetActive(false);

        lesson1_audio.SetActive(false);
        lesson2_audio.SetActive(false);
        lesson3_audio.SetActive(false);

        monitor1_movie.SetActive(false);
        monitor2_movie.SetActive(false);

        HP.SetActive(false);



    }


    private void Call()

    {
        f_lesson1_sound.SetActive(false);
        f_lesson2_sound.SetActive(false);
        f_lesson3_sound.SetActive(false);
        s_lesson1_sound.SetActive(false);
        s_lesson2_sound.SetActive(false);
        s_lesson3_sound.SetActive(false);
        t_lesson1_sound.SetActive(false);
        t_lesson2_sound.SetActive(false);
        t_lesson3_sound.SetActive(false);
    }



    void Update()
    {



        //↓↓↓↓↓↓↓↓↓↓↓ ム-ビー↓↓↓↓↓↓↓↓↓↓↓↓↓↓

        if (op_tutorial.activeSelf)
        {

            Invoke("Tutorial", 115.0f);
        }

        if (lesson1.activeSelf)
        {
            BackPanel.SetActive(true);
            Invoke("lesson1_fin", 52.0f);

        }

        if (lesson2.activeSelf)
        {
            //BackPanel.SetActive(true);
            Invoke("lesson2_fin", 75.0f);


        }

        if (lesson3.activeSelf)
        {
            Invoke("lesson3_true_end", 5.5f);

        }


        if (Porigon.activeSelf)
        {
            Invoke("error_switch", 0.1f);
            Invoke("Porigon_over", 10.0f);
            characon_switch.SetActive(false);
            error_audio.SetActive(true);
            //  Destroy(gameover);
        }

        if (gameover.activeSelf)
        {
            Invoke("gameover_continue", 5.0f);

        }

        //↓↓↓↓↓↓↓↓↓↓↓ lesson3画面↓↓↓↓↓↓↓↓↓↓↓↓↓↓



        if (switch_error01.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_01.SetActive(true);
            switch_error01.SetActive(false);
            Invoke("error01", 1.0f);



        }

        if (switch_error02.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_02.SetActive(true);
            switch_error02.SetActive(false);
            Invoke("error02", 1.0f);

        }

        if (switch_error03.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_03.SetActive(true);
            switch_error03.SetActive(false);
            Invoke("error03", 1.0f);
        }

        if (switch_error04.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_04.SetActive(true);
            switch_error04.SetActive(false);
            Invoke("error04", 1.0f);
        }

        if (switch_error05.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_05.SetActive(true);
            switch_error05.SetActive(false);
            Invoke("error05", 1.0f);
        }

        if (switch_error06.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_06.SetActive(true);
            switch_error06.SetActive(false);
            Invoke("error06", 1.0f);
        }

        if (switch_error07.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_07.SetActive(true);
            switch_error07.SetActive(false);
            Invoke("error07", 1.0f);
        }

        if (switch_error08.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_08.SetActive(true);
            switch_error08.SetActive(false);
            Invoke("error08", 1.0f);
        }

        if (switch_error09.activeSelf && Input.GetKeyDown(KeyCode.E))
        {

            error_09.SetActive(true);
            switch_error09.SetActive(false);
            Invoke("error09", 1.0f);
            Invoke("error_end", 1.0f);
        }



        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {

            Destroy(error_00);
            error_01.SetActive(false);
            error_02.SetActive(false);
            error_03.SetActive(false);
            error_04.SetActive(false);
            error_05.SetActive(false);
            error_06.SetActive(false);
            error_07.SetActive(false);
            error_08.SetActive(false);
            error_09.SetActive(false);
            lesson3_title.SetActive(true);
            audio.SetActive(true);
            HP.SetActive(true);
            damagecube_2.SetActive(true);
            damagecube_3.SetActive(true);
            monitor2_movie.SetActive(false);
            //status.SetActive(true);
            Directional_light2.SetActive(true);
            R_light.SetActive(false);
            G_light.SetActive(false);
            B_light.SetActive(false);
            freeze.SetActive(false);
            BackPanel.SetActive(false);
            Destroy(Porigon);
            error_audio.SetActive(false);
            first_enemy.SetActive(false);
            switch_error10.SetActive(false);
            characon_switch.SetActive(true);
            Invoke("error_switch", 0.5f);
            Invoke("lesson3_fin", 0.5f);
        }




        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (tyuunyuutyu.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }




        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }




        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_error10.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }






        //↓↓↓↓↓↓↓↓↓↓↓skip 画面↓↓↓↓↓↓↓↓↓↓↓↓↓↓




        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))

        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip1.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }





        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }



        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))

        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip2.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }



        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }



        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))

        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }
        if (switch_skip3.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }




        //↓↓↓↓↓↓↓↓↓↓↓lesson select画面↓↓↓↓↓↓↓↓↓↓↓↓↓↓




        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            WhitePanel.SetActive(true);
            trueSE.SetActive(true);
            Invoke("errorsound", 3.0f);
            Invoke("skip2", 2.0f);
            
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);

        }



        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }


        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson1.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }



        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            Invoke("skip3", 2.0f);
            trueSE.SetActive(true);
            Invoke("errorsound", 4.0f);
            Select2.SetActive(false);
            switch_lesson2.SetActive(false);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.W))
        {

            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);

        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }


        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }
        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson2.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }




        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.H))
        {

            Invoke("errorsound", 4.0f);
            Invoke("error_switch", 0.5f);
            Destroy(Select3);
            t_lesson3_sound.SetActive(true);
            switch_lesson3.SetActive(false);
            trueSE.SetActive(true);
            Invoke("lesson3_movie", 3.0f);



        }


        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }


        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }


        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }

        if (switch_lesson3.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);

            Invoke("errorsound", 1.0f);
        }


        //    if (switch_body1.activeSelf && Input.GetMouseButton(1))
        //    {
        //        thisbody1.SetActive(true);
        //        thisbody2.SetActive(false);
        //        thisbody3.SetActive(false);
        //        thisbody4.SetActive(false);
        //
        //        enemy1.SetActive(false);
        //        thisbodysound.SetActive(true);
        //        enemys1.SetActive(true);
        //        //tyuunyuu.SetActive(true);
        //        //tyunyu_audio.SetActive(true);
        //        Destroy(body_select);
        //        Directional_light.SetActive(false);
        //        Select2.SetActive(true);
        //        switch_lesson2.SetActive(true);
        //    }

        //↓↓↓↓↓↓↓↓↓↓↓body select画面↓↓↓↓↓↓↓↓↓↓↓↓↓↓

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.Q))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch_body.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }




        if (switch_body.activeSelf && switch_body1.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            thisbody1.SetActive(false);
            thisbody2.SetActive(true);
            thisbody3.SetActive(false);
            thisbody4.SetActive(false);
            enemy2.SetActive(false);
            thisbodysound.SetActive(true);
            enemys2.SetActive(true);
            //tyuunyuu.SetActive(true);
            //tyunyu_audio.SetActive(true);
            damage2.SetActive(true);
            body_select.SetActive(false);
            camera.SetActive(false);
            Directional_light.SetActive(false);
            WhitePanel.SetActive(true);
            switch_body1.SetActive(false);
            ketteiSE.SetActive(true);
            Invoke("errorsound", 1.0f);
            Invoke("error_switch", 0.5f);
            switch_body.SetActive(false);
            tyuunyuutyu.SetActive(true);
            tyunyu_audio.SetActive(true);
            if (tyuunyuutyu.activeSelf)
            {
                Invoke("lesson2_start", 14.0f);

            }
        }



        if (switch_body.activeSelf && switch_body2.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            thisbody1.SetActive(false);
            thisbody2.SetActive(false);
            thisbody3.SetActive(true);
            thisbody4.SetActive(false);

            enemy3.SetActive(false);
            thisbodysound.SetActive(true);
            enemys3.SetActive(true);
            //tyuunyuu.SetActive(true);
            //tyunyu_audio.SetActive(true);
            damage3.SetActive(true);
            body_select.SetActive(false);
            camera.SetActive(false);
            Directional_light.SetActive(false);
            WhitePanel.SetActive(true);
            switch_body2.SetActive(false);
            ketteiSE.SetActive(true);
            Invoke("errorsound", 1.0f);
            Invoke("error_switch", 0.5f);
            tyuunyuutyu.SetActive(true);
            tyunyu_audio.SetActive(true);
            switch_body.SetActive(false);
            if (tyuunyuutyu.activeSelf)
            {
                Invoke("lesson2_start", 12.0f);

            }

        }



        //↓↓↓↓↓↓↓↓↓↓↓perfect画面↓↓↓↓↓↓↓↓↓↓↓↓↓↓



        if (enemys1.activeSelf && enemys2.activeSelf && enemys3.activeSelf && enemys4.activeSelf)
        {
            perfect.SetActive(true);
            lesson2_tenmetu.SetActive(false);
            sousaban.SetActive(false);
            remaining__enemy.SetActive(false);

        }

        if (perfect.activeSelf)
        {
            Invoke("lesson_start", 2.0f);
            characon_switch.SetActive(false);
            switch_secret.SetActive(false);
            Destroy(delete);
            // Countdown.SetActive(false);

        }



    }



    //↓↓↓↓↓↓↓↓↓↓↓以下、アップデートコマンド終わり↓↓↓↓↓↓↓↓↓↓↓↓↓↓



    void Tutorial()

    {
        //  Button_skip1.SetActive(false);
        op_tutorial.SetActive(false);
        Select1.SetActive(true);
        sound.SetActive(false);
        switch_skip1.SetActive(false);
        switch_lesson1.SetActive(true);
        ketteiSE.SetActive(false);
        switch_error.SetActive(false);
    }

    void lesson1_fin()

    {
        lesson1.SetActive(false);
        audio.SetActive(true);
        lesson1_audio.SetActive(false);
        l1_title.SetActive(true);
        WhitePanel.SetActive(false);
        monitor1_movie.SetActive(true);
        switch_skip2.SetActive(false);
        switch_body1.SetActive(true);
        switch_error.SetActive(false);
        body_select.SetActive(true);
        camera.SetActive(true);
        // lesson1_effect.SetActive(true);
        switch_body.SetActive(true);
        switch_lesson1.SetActive(false);
        if (l1_title.activeSelf)
        {
            Invoke("title", 4.0f);

        }



    }

    void lesson2_fin()

    {

        lesson2.SetActive(false);
        WhitePanel.SetActive(false);
        Enemy_body1.SetActive(true);
        Enemy_body2.SetActive(true);
        Enemy_body3.SetActive(true);
        Enemy_body4.SetActive(true);
        lesson2_title.SetActive(true);
        audio.SetActive(true);
        lesson2_audio.SetActive(false);
        monitor1_movie.SetActive(false);
        //status.SetActive(true);
        Countdown.SetActive(true);
        switch_skip3.SetActive(false);
        characon_switch.SetActive(true);
        switch_secret.SetActive(true);
        switch_error.SetActive(false);
        lesson2_tenmetu.SetActive(true);
        sousaban.SetActive(true);
        remaining__enemy.SetActive(true);
        Invoke("l2_title", 4.0f);
    }





    void lesson3_fin()

    {

        //bgm.SetActive(false);
        lesson3_title.SetActive(true);
        HP.SetActive(true);
        damagecube_2.SetActive(true);
        damagecube_3.SetActive(true);
        monitor2_movie.SetActive(false);
        //status.SetActive(true);
        Directional_light2.SetActive(true);
        R_light.SetActive(false);
        G_light.SetActive(false);
        B_light.SetActive(false);
        // bgm.SetActive(false);
        //error_00.SetActive(true);
        //freeze.SetActive(true);
        //colider.SetActive(true);
        characon_switch.SetActive(true);
        first_enemy.SetActive(false);
        Invoke("error_switch", 0.5f);
        lesson2_tenmetu.SetActive(true);
        cngratulation.SetActive(true);


    }


    void lesson3_true_end()

    {
        Porigon.SetActive(true);
        lesson3.SetActive(false);
        lesson3_audio.SetActive(false);
        bgm.SetActive(false);
    }


    void title()

    {

        Destroy(l1_title);

    }

    void Porigon_over()

    {
        error_00.SetActive(true);
        switch_error03.SetActive(true);

        switch_error.SetActive(false);
        error_error.SetActive(true);

        // Porigon.SetActive(true);

        // mouse.SetActive(false);
        //Cursor.visible = true;
    }

    void lesson_start()
    {
        Select3.SetActive(true);
        switch_lesson3.SetActive(true);
        perfect.SetActive(false);
        enemys1.SetActive(false);
        enemys2.SetActive(false);
        enemys3.SetActive(false);
        enemys4.SetActive(false);
        switch_error.SetActive(false);

    }

    void lesson2_start()
    {
        tyuunyuutyu.SetActive(false);
        tyunyu_audio.SetActive(false);
        switch_lesson2.SetActive(true);
        Select2.SetActive(true);
        // WhitePanel.SetActive(false);
        switch_error.SetActive(false);

    }


    void errorsound()
    {
        errorSE.SetActive(false);
        ketteiSE.SetActive(false);
       
        trueSE.SetActive(false);

    }

    void error01()
    {
        switch_error02.SetActive(true);
    }


    void error02()
    {
        switch_error03.SetActive(true);
    }


    void error03()
    {
        switch_error04.SetActive(true);
    }


    void error04()
    {
        switch_error05.SetActive(true);
    }


    void error05()
    {
        switch_error06.SetActive(true);
    }


    void error06()
    {
        switch_error07.SetActive(true);
    }


    void error07()
    {
        switch_error08.SetActive(true);
    }


    void error08()
    {
        switch_error09.SetActive(true);
    }

    void error09()
    {
        switch_error10.SetActive(true);
    }

    void error_switch()
    {
        switch_error.SetActive(true);
    }



    void skip2()
    {
        switch_skip2.SetActive(true);
        lesson1.SetActive(true);
        lesson1_audio.SetActive(true);
        Destroy(Select1);
        f_lesson1_sound.SetActive(true);
        switch_lesson1.SetActive(false);
       
        if (f_lesson1_sound.activeSelf)
        {
            Invoke("Call", 1.0f);

        }
    }

    void skip3()
    {
        switch_skip3.SetActive(true);
        lesson2.SetActive(true);
        lesson2_audio.SetActive(true);
        //  s_lesson2_sound.SetActive(true);
        //  errorSE_lesson2.SetActive(true);



    }

    void lesson3_movie()
    {

        lesson3_audio.SetActive(true);
        lesson3.SetActive(true);
        if (t_lesson3_sound.activeSelf)
        {
            Invoke("Call", 1.0f);

        }

    }


    void error_end()
    {
        error_error.SetActive(false);

    }

    void l2_title()
    {
        Destroy(lesson2_title);
        BackPanel.SetActive(false);

    }

    void gameover_continue()
    {
        continue_obj.SetActive(true);
        continue_count.SetActive(true);
        sousaban.SetActive(false);
        remaining__enemy.SetActive(false);
        lesson2_tenmetu.SetActive(false);
    }

}
