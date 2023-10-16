using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour
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
        PubVolume.pubVolume = newSliderValue; 
	}
    
    public class PubVolume
    {
        public static float pubVolume = 1f;
    }
   
    
}
