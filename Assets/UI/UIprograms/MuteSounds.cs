using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSounds : MonoBehaviour
{
    public GameObject m;
    public AudioSource audioSource;
    
      void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

     void OnClickStartButton()
    {
        audioSource.volume = 0;
    }
}
