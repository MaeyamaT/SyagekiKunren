using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneChangeOption : MonoBehaviour
{
    public GameObject option;
    public GameObject cross;
    public CameraController camController;
    public void OptionUI()
    {
        if (option.activeSelf)
        {
            option.SetActive(false);
            camController.GetComponent<CameraController>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            cross.SetActive(true);

        }else {
            option.SetActive(true);
        }

    }
}
