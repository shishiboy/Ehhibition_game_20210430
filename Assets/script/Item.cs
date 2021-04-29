using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    // トリガーとの接触時に呼ばれるコールバック
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //プレイヤーが武器を取ったら消す
        {
            Destroy(gameObject);
        }
    }
}