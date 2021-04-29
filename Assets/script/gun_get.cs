using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_get : MonoBehaviour
{

    public GameObject gun_floor;

    public GameObject gun_hand;

    public GameObject click;

    private bool isNear;


    // Start is called before the first frame update
    void Start()
    {
        gun_floor.SetActive(true);

        gun_hand.SetActive(false);

        click.SetActive(true);

        isNear = false;
    }




    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            click.SetActive(true);

            isNear = true;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && isNear)
        {

            gun_floor.SetActive(false);

            gun_hand.SetActive(true);

        }

    }

    void OnTriggerExit(Collider collider)
    {


        if (collider.CompareTag("Finish"))
        {

            isNear = false;
        }
    }
}
