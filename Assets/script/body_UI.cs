using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body_UI : MonoBehaviour
{

    public GameObject sense_ball;
    public GameObject Intution_ball;
    public GameObject thinking_ball;
    public GameObject emotion_ball;
    public GameObject enemys1;
    public GameObject enemys2;
    public GameObject enemys3;
    public GameObject enemys4;
    public GameObject Enemy_body1;
    public GameObject Enemy_body2;
    public GameObject Enemy_body3;
    public GameObject Enemy_body4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy_body1.activeSelf)
        {

            sense_ball.SetActive(true);
        }

        if (Enemy_body2.activeSelf)
        {

            thinking_ball.SetActive(true);
        }

        if (Enemy_body3.activeSelf)
        {

            Intution_ball.SetActive(true);
        }

        if (Enemy_body4.activeSelf)
        {

            emotion_ball.SetActive(false);
        }




        if (enemys1.activeSelf)
        {

            sense_ball.SetActive(false);
        }

        if (enemys3.activeSelf)
        {

            Intution_ball.SetActive(false);
        }

        if (enemys4.activeSelf)
        {

            emotion_ball.SetActive(false);
        }

        if (enemys2.activeSelf)
        {

            thinking_ball.SetActive(false);
        }
    }
}
