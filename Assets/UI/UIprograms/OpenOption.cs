using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SocialPlatforms.Impl;
public class OpenOption : MonoBehaviour
{
    public GameObject op;
    public void Update(){
        if(Input.GetKeyDown(KeyCode.O))
        {
            op.SetActive(!op.activeSelf);  
        }
    }
}
