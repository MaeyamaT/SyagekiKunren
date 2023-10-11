using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SocialPlatforms.Impl;
//using UnityEngine.Cursor;
public class OpenOption : MonoBehaviour
{
    public GameObject op;
    // Update is called once per frame
    public void Update(){
        if(Input.GetKeyDown(KeyCode.O))
        {
            op.SetActive(!op.activeSelf);  
         //   Cursor.lockState = CursorLockMode.None;
           // Cursor.visible = true;
          
        }
    }
}
