using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_audio : MonoBehaviour
{


    public AudioClip audioClip1;

    private AudioSource audioSource;


    // Update is called once per frame
    void OnTriggerEnter(Collider hit)
    {


        if (hit.CompareTag("Player"))
        {
            

            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip1;
            audioSource.Play();

        }
    }
}
