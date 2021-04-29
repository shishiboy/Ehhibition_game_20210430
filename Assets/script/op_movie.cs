using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;

public class op_movie : MonoBehaviour
{
    //public GameObject start_movie;
    public GameObject logo;
    public GameObject tutorial;
    public GameObject tutorial_sound;
    public GameObject bgm;
    public GameObject switch1;
    public GameObject switch_skip1;
    public GameObject errorSE;
    public GameObject trueSE;
    public GameObject switch_start;

    void Update()
    {

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Q)) {


            tutorial.SetActive(true);
            Destroy(logo);
            tutorial_sound.SetActive(true);
            bgm.SetActive(true);
            switch_start.SetActive(false);
            trueSE.SetActive(true);
            Invoke("skip1", 1.0f);
            Invoke("errorsound", 4.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.A))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.S))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.D))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

    

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.G))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);


        }

       

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.H))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Alpha1))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Alpha2))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Alpha4))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }

        if (switch1.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            errorSE.SetActive(true);
            Invoke("errorsound", 1.0f);
        }


    }



    void skip1()

    {
        switch_skip1.SetActive(true);
        switch1.SetActive(false);
    }

    //public void op_change()
    //{
    // start_movie.SetActive(false);
    // logo.SetActive(true);

    //}

    // ボタンをクリックするとBattleSceneに移動します

    void errorsound() 
    {

        errorSE.SetActive(false);
        trueSE.SetActive(false);
    }
}