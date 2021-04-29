using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZoomController : MonoBehaviour
{
    private Camera cam;
    private float zoom;
    private float view;
    float seconds;
 //   public GameObject Zoomeffect;


    void Start()
    {
        cam = GetComponent<Camera>();
        view = cam.fieldOfView;

      //  Zoomeffect.SetActive(false);
    }

void Update()
    {
        cam.fieldOfView = view + zoom;



        // 最小値と最大値を決める（自由に変更可能）
        if (cam.fieldOfView < 10f)
        {
            cam.fieldOfView = 10f;

           

        }

        // 「自分の主観カメラ」を基準に数値を決めてください。
        if (cam.fieldOfView > 70f)
        {
            cam.fieldOfView = 70f;

        //   Zoomeffect.SetActive(false);

        }

        
        if (Input.GetKey(KeyCode.Space))
        {
            // どれくらいの速度でzoomを変更させるかも自由です。
            zoom -= 50f;

          //  Zoomeffect.SetActive(true);
        }

        seconds += Time.deltaTime;
        if (seconds >= 0.01)
        {
            seconds = 0;
            zoom += 2f;

        }
        if (zoom > 20)
        {
            zoom = 20f;

        }
        if (zoom < -10)
        {
            zoom = -10f;

        }


    }
}