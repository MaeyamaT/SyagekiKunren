using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOpenOption : MonoBehaviour
{
    public GameObject option;
    public CameraController camCon;
    public GameObject cross;
    // Update is called once per frame
    public void Update(){
        if(Input.GetKeyDown(KeyCode.O))
        {
            option.SetActive(true);
            camCon.GetComponent<CameraController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            cross.SetActive(false);
        }
    }
}
