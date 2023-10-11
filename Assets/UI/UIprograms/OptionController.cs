using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionController : MonoBehaviour
{
    public Slider sensitivitySlider; 
   // public CameraController c;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        sensitivitySlider.value=PlayerPrefs.GetFloat("MouseSensitivity",0.5f);
    }

    // Update is called once per frame
    public void SoundSliderOnValueChange(float newSliderValue)
	{
		audioSource.volume = newSliderValue;
	}
    public void ChangeSensitivity(float value)
    {
        PlayerPrefs.SetFloat("MouseSensitivity",value);   
        PlayerPrefs.Save();
        UpdateMouseSensitivity(value);
    }
    private void UpdateMouseSensitivity(float sensitivity)
    {
        Debug.Log("Sensitivity : " + sensitivity);
    }
    
}
