using UnityEngine;

using System.Collections;

using System.Collections.Generic;



[RequireComponent(typeof(AudioSource))]

public class FootstepSEPlayerSimple2 : MonoBehaviour

{

    [SerializeField] AudioClip[] clips;

    [SerializeField] bool randomizePitch = true;

    [SerializeField] float pitchRange = 0.1f;

    public GameObject switch1;


    protected AudioSource source;



    private void Awake()

    {

        // アタッチしたオーディオソースのうち1番目を使用する

        source = GetComponents<AudioSource>()[0];

    }



    public void PlayFootstepSE()

    {

        if (switch1.activeSelf && randomizePitch)

            source.pitch = 1.0f + Random.Range(-pitchRange, pitchRange);



        source.PlayOneShot(clips[Random.Range(0, clips.Length)]);

    }



}