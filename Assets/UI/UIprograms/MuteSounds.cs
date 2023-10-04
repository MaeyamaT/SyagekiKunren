using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSounds : MonoBehaviour
{
    public GameObject m;
    public void Start()
    {

    }

     void OnClickStartButton()
    {
        if (m.activeSelf)
        {
            m.SetActive(false);
        }
        else
        {
            m.SetActive(true);
        }
    }
}
