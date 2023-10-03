using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeOption : MonoBehaviour
{
    public GameObject o;


    public void OptionUI()
    {
        if (o.activeSelf)
        {
            o.SetActive(false);
        }else{
            o.SetActive(true);
        }

    }
}
