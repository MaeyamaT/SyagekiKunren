using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeMain : MonoBehaviour
{
    public void OnClickStartButton()
{
    SceneManager.LoadScene("Main");
}
}
