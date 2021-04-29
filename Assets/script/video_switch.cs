using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video_switch : MonoBehaviour
{
    private float waitSeconds = 9 * 1;
    [SerializeField] GameObject Panel;

    IEnumerator getStart()
    {
        yield return new WaitForSeconds(waitSeconds);
        Panel.SetActive(false);
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
