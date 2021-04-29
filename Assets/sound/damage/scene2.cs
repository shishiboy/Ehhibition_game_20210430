using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2 : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public GameObject monitor2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1.activeSelf && enemy2.activeSelf && enemy3.activeSelf && enemy4.activeSelf)
        {
            Invoke("Call", 10.0f);

        }
    }

    void Call()
    {

        monitor2.SetActive(true);
    }
}
