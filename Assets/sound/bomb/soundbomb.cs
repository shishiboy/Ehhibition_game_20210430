using UnityEngine;
using UnityEngine.UI;
public class soundbomb : MonoBehaviour
{
    public GameObject enemy_s;

   AudioSource audio;


    void start()
    {
        audio = GetComponent<AudioSource>();
    }

    void update()
    {
        if (enemy_s.activeSelf)
        {
            audio.Play();
        }
    }

}