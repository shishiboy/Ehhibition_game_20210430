using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class HitController : MonoBehaviour
{
    //倒したときのエフェクト
    public GameObject breakEffect;

    //当たり判定メソッド
    private void OnTriggerEnter(Collision collision)
    {
        //衝突したオブジェクトがBullet(大砲の弾)だったとき
        if (GetComponent<Collider>().gameObject.tag == "Player")
        {
           
            //エフェクトを発生させる
            GenerateEffect();
        }

    }

    //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(breakEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = gameObject.transform.position;
    }
}