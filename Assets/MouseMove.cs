using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{

    //操作キャラの位置
    Vector3 playerPos;
    //向く方向
    Vector3 direction;
    public Rigidbody rb;
    //スピード
    float speed = 0.03f;
    //ジャンプ力
    float thrust = 400;

    public GameObject switch1;
    //移動できるかできないか
    bool moveOn;

    private Transform character;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveOn = true;
    }

    void Update()
    {
        //マウス右ボタンで移動できるかどうかを切り替え
        if (switch1.activeSelf)
        {
            moveOn = !moveOn;
        }

        
    }

    void FixedUpdate()
    {
        //Raycastの情報を入れる
        RaycastHit hit;

        if (moveOn)
        {
            //カメラからマウスカーソルの位置に向けて出る
            //仮想の線に当たった場所に移動する
            float Y_Rotation = Input.GetAxis("Mouse Y");

            character.transform.Rotate(0, Y_Rotation, 0);

            //左クリックでジャンプする

        }
    }
}