using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreAudio : MonoBehaviour
{
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
         GetComponent<AudioSource>().volume = 1.0f *OptionController.PubVolume.pubVolume;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
