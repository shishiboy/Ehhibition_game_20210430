using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class a1room : MonoBehaviour
{

    [SerializeField] GameObject door3;
    [SerializeField] GameObject static3;
    [SerializeField] GameObject a1;
    [SerializeField] GameObject start;

    void Start()
    {

       door3.SetActive(true);
       static3.SetActive(false);

    }

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            door3.SetActive(false);
            static3.SetActive(true);
            a1.SetActive(true);
            start.SetActive(false);
        }
    }
}