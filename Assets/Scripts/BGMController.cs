using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public GameController gc;
    AudioSource audioSource;
    public AudioClip[] clips;
    bool isChenged=false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gc.totalTime < 20 && isChenged==false)
        {
            audioSource.PlayOneShot(clips[2]);
            audioSource.clip=clips[1];
            audioSource.Play();
            isChenged = true;

        }

    }

}