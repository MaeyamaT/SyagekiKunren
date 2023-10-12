using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensiChange : MonoBehaviour
{
     public Slider sensitivitySlider; 
    // Start is called before the first frame update
    void Start()
    {
         sensitivitySlider.value=PlayerPrefs.GetFloat("MouseSensitivity",0.5f);
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
