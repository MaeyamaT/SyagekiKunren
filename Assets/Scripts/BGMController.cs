using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMController : MonoBehaviour
{
    public GameController gc;
    AudioSource audioSource;
    public AudioClip[] clips;
    bool isChenged=false;
    AudioSource audioSlider;
    public Slider volumeSlider;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Sliderと連動させる処理
        audioSlider = gameObject.GetComponent<AudioSource>();
           //Titleと同じ音量にする処理 
       volumeSlider.value = OptionController.PubVolume.pubVolume;
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
    //Sliderと連動させる処理
     public void SoundSliderOnValueChange(float newSliderValue)
	{
		audioSource.volume = newSliderValue;
    
    }
    

}