using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene02 : MonoBehaviour
{
    private float waitSeconds = 9 * 1;
    private string StartSceneName = "L02"; // <- ""内に 最初のシーン名を入れる

    IEnumerator getStart()
    {
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(StartSceneName);
    }

    private void Start()
    {
        StartCoroutine("getStart");
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            StopCoroutine("getStart");
            StartCoroutine("getStart");
            waitSeconds = 9 * 1;
        }


    }
}
