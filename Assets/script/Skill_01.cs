using UnityEngine;
using System.Collections;

public class Skill_01 : MonoBehaviour
{

    void Update()
    {
        // GameObject型の配列cubesに、"box"タグのついたオブジェクトをすべて格納
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("box");

        // GameObject型の変数cubeに、cubesの中身を順番に取り出す。
        // foreachは配列の要素の数だけループします。
        foreach (GameObject cube in cubes) 
            // 左クリックで実行
            if (Input.GetMouseButtonDown(0))
        {

           
                // 消す！
                cube.SetActive(true);
            
            
        }
    }
}
