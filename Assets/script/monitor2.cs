using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class monitor2 : MonoBehaviour
{

    [SerializeField] GameObject Switch1;
    [SerializeField] GameObject Switch2;
    //[SerializeField] GameObject movie2;

    public GameObject s_select;
    public GameObject colider;
    public GameObject status;
  

    void Start()

    {

    }

    private void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            Invoke("Call", 2.0f);

         

        }

    }


    private void Call()

    {
       // movie2.SetActive(true);
        s_select.SetActive(true);
       //Destroy(Switch1);
       // Destroy(Switch2);
        colider.SetActive(false);
        status.SetActive(false);

      
    }

  

}




