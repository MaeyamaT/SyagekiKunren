using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSounds : MonoBehaviour
{
    public Button muteButton;
    public AudioSource audioSource;
    
      void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        muteButton.onClick.AddListener(MuteSound);
    }

     void MuteSound()
    {
        audioSource.volume = 0.0f;
    }
}
