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
        CameraController.sensitivity = 1.0f * sensitivitySlider.value;
    }
     void Update()
     {
        CameraController.sensitivity = 1.0f * sensitivitySlider.value;
        
     }
    private void UpdateMouseSensitivity(float sensitivity)
    {
        Debug.Log("Sensitivity : " + sensitivity);
    }
}
