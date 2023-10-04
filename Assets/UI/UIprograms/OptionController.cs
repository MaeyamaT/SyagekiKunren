using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OptionController : MonoBehaviour
{
    public int MOUSensi; 
   // public CameraController c;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void SoundSliderOnValueChange(float newSliderValue)
	{
		audioSource.volume = newSliderValue;
	}
   // void Update()
//    {}

    /*     Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                c.GetComponent<CameraController>().enabled = true; 

 Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                c.GetComponent<CameraController>().enabled = false; 
    */
    
}
