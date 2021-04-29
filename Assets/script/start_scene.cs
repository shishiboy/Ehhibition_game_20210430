using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start_scene : MonoBehaviour
{
    public GameObject start_movie;
    public GameObject logo;


    void Update()
    {


        if (start_movie.activeSelf)
        {

            Invoke("op_movie", 90.0f);

        }

    }

    public void op_movie()
    {
        start_movie.SetActive(false);
        logo.SetActive(true);

    }

    // ボタンをクリックするとBattleSceneに移動します
    public void ButtonClicked()
    {
        SceneManager.LoadScene("0717");
    }
}