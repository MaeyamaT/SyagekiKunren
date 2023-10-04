using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenOption : MonoBehaviour
{
    public GameObject op;
    // Update is called once per frame
    public void Update(){
        if(Input.GetKeyDown(KeyCode.O))
        {
            op.SetActive(!op.activeSelf);  
                
        }
    }
}
