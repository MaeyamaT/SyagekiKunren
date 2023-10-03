using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptionESC : MonoBehaviour
{
    public GameObject o;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            o.SetActive(!o.activeSelf);
        }
    }
}
