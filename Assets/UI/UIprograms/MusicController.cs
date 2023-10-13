using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    public void SoundSliderOnValueChange(float newSliderValue)
	{
		audioSource.volume = newSliderValue;
	}
   
    
}
