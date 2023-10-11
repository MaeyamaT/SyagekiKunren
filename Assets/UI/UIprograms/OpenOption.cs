using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOption : MonoBehaviour
{
    public GameObject op;
    public CameraController camCon;
    
    // Update is called once per frame
    public void Update(){
        if(Input.GetKeyDown(KeyCode.O))
        {
            op.SetActive(true); 
            camCon.GetComponent<CameraController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
