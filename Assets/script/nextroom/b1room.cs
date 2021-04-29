using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class b1room : MonoBehaviour
{

    [SerializeField] GameObject door2;
    [SerializeField] GameObject static2;
    [SerializeField] GameObject b1;
    [SerializeField] GameObject start;

    void Start()
    {

        door2.SetActive(true);
        static2.SetActive(false);

    }

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Finish"))
        {

            door2.SetActive(false);
            static2.SetActive(true);
            b1.SetActive(true);
            start.SetActive(false);

        }
    }
}