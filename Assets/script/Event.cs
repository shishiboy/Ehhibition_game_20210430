using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{

    //　ドアエリアに入っているかどうか
    private bool isNear;
    //　ドアのアニメーター
    private Animator animator;

    public GameObject enemy1;

    void Start()
    {
        isNear = false;
        animator = transform.parent.GetComponent<Animator>();
    }

    void Update()
    {
        if (enemy1.activeSelf && isNear)
        {
            animator.SetBool("Open", !animator.GetBool("Open"));
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            isNear = true;
        }
    }

   
}