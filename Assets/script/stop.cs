using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)

    {

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Finish");
        foreach (GameObject cube in cubes)

            if (collider.gameObject.tag == "Player")

            {
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


            }
    }
}
