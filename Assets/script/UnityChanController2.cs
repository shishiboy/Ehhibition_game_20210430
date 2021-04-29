using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]
public class UnityChanController2 : MonoBehaviour
{
    private Animator animator;

    private int goBack;

    public GameObject switch1;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        goBack = Animator.StringToHash("Go Back");
    }
    // Update is called once per frame
    void Update()
    {


        if (switch1.activeSelf && Input.GetKey(KeyCode.S))
        {
            animator.SetBool(goBack, true);
        }
        else
        {
            animator.SetBool(goBack, false);
        }
    }
}