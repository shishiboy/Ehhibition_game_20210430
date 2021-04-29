using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class monitor : MonoBehaviour
{

    [SerializeField] GameObject Switch1;
   // [SerializeField] GameObject movie2;

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
            
                Invoke("Call", 4.0f);

           
          
        }

    }


    private void Call()

    {
        //movie2.SetActive(true);
        s_select.SetActive(true);
        Switch1.SetActive(false);
        colider.SetActive(false);
        status.SetActive(false);

       
    }
   
}

  

   
