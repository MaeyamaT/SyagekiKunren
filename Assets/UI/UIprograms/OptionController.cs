using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour
{
    public CameraController c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                c.GetComponent<CameraController>().enabled = true; 

 Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                c.GetComponent<CameraController>().enabled = false; 

    }
}
