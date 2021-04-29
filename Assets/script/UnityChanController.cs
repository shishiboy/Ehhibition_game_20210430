using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]
public class UnityChanController : MonoBehaviour
{
    private Animator animator;
    private int doWalkId;
    public GameObject switch1;
    

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();

        doWalkId = Animator.StringToHash("Do Walk");

      

}
    // Update is called once per frame
    void Update()
    {
        if (switch1.activeSelf && Input.GetKey(KeyCode.W))
        {
            animator.SetBool(doWalkId, true);
        }


        else if (switch1.activeSelf && Input.GetKey(KeyCode.A))
        {
            animator.SetBool(doWalkId, true);
        }

        else if (switch1.activeSelf && Input.GetKey(KeyCode.D))
        {
            animator.SetBool(doWalkId, true);
        }

        else if (switch1.activeSelf && Input.GetKey(KeyCode.S))
        {
            animator.SetBool(doWalkId, true);
        }
        else
        {
            animator.SetBool(doWalkId, false);
        }


    }
}